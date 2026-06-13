// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Generic
// Classes: 100
// Methods: 6177

namespace ThirdParty.DotNet.System.Collections.Generic
{
    public class List`1
    {
        public int DefaultCapacity;
        public SlotDefinition[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public SlotDefinition[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3B87770 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3B879E0
        public void get_Item(){} // RVA: 0x38727E0
        public void set_Item(){} // RVA: 0x3872830
        public void IsCompatibleObject(){} // RVA: 0x38728D0
        public void System.Collections.IList.get_Item(){} // RVA: 0x3872930
        public void System.Collections.IList.set_Item(){} // RVA: 0x3872990
        public void Add(){} // RVA: 0x5BEEC0
        public void AddWithResize(){} // RVA: 0x3872B00
        public void System.Collections.IList.Add(){} // RVA: 0x3872BC0
        public void AddRange(){} // RVA: 0x3B87A90
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3B87BC0 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3B87C30
        public void System.Collections.IList.Contains(){} // RVA: 0x3B87CA0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x38731E0
        public void Exists(){} // RVA: 0x3873240
        public void Find(){} // RVA: 0x38732F0
        public void FindAll(){} // RVA: 0x38733C0
        public void FindIndex(){} // RVA: 0x3873640 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x3873800 | overloaded x2
        public void ForEach(){} // RVA: 0x38738F0
        public void GetEnumerator(){} // RVA: 0x38739A0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x3873A30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3873A30
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3B87FF0 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3B87E50
        public void Insert(){} // RVA: 0x3873E50
        public void System.Collections.IList.Insert(){} // RVA: 0x3873F80
        public void InsertRange(){} // RVA: 0x3B88060
        public void LastIndexOf(){} // RVA: 0x3B884B0 | overloaded x3
        public void Remove(){} // RVA: 0x3B88570
        public void System.Collections.IList.Remove(){} // RVA: 0x3B88690
        public void RemoveAll(){} // RVA: 0x3874860
        public void RemoveAt(){} // RVA: 0x3874A00
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3874BE0 | overloaded x2
        public void Sort(){} // RVA: 0x3874E60 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3875010
        public void TrueForAll(){} // RVA: 0x3875060
        public void AddEnumerable(){} // RVA: 0x3B88AC0
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public System.Collections.Generic.KeyValuePair`2<UnityEngine.PropertyName,object>[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public System.Collections.Generic.KeyValuePair`2<UnityEngine.PropertyName,object>[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x38A01A0 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x38A0410
        public void get_Item(){} // RVA: 0x38727E0
        public void set_Item(){} // RVA: 0x387A580
        public void IsCompatibleObject(){} // RVA: 0x38728D0
        public void System.Collections.IList.get_Item(){} // RVA: 0x3872930
        public void System.Collections.IList.set_Item(){} // RVA: 0x387A620
        public void Add(){} // RVA: 0xE7CE50
        public void AddWithResize(){} // RVA: 0x387A790
        public void System.Collections.IList.Add(){} // RVA: 0x387A850
        public void AddRange(){} // RVA: 0x38A04C0
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x38A05F0 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x38A0660
        public void System.Collections.IList.Contains(){} // RVA: 0x38A06D0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x38731E0
        public void Exists(){} // RVA: 0x3873240
        public void Find(){} // RVA: 0x38732F0
        public void FindAll(){} // RVA: 0x387ACD0
        public void FindIndex(){} // RVA: 0x3873640 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x3873800 | overloaded x2
        public void ForEach(){} // RVA: 0x38738F0
        public void GetEnumerator(){} // RVA: 0x38739A0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x3873A30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3873A30
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x38A0A20 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x38A0880
        public void Insert(){} // RVA: 0x387B0F0
        public void System.Collections.IList.Insert(){} // RVA: 0x387B220
        public void InsertRange(){} // RVA: 0x38A0A90
        public void LastIndexOf(){} // RVA: 0x38A0EE0 | overloaded x3
        public void Remove(){} // RVA: 0x38A0FA0
        public void System.Collections.IList.Remove(){} // RVA: 0x38A10C0
        public void RemoveAll(){} // RVA: 0x387BB70
        public void RemoveAt(){} // RVA: 0x387BD10
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x387BE50 | overloaded x2
        public void Sort(){} // RVA: 0x387C0D0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3875010
        public void TrueForAll(){} // RVA: 0x3875060
        public void AddEnumerable(){} // RVA: 0x38A14F0
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public UnityEngine.Yoga.YogaNode[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public UnityEngine.Yoga.YogaNode[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public Newtonsoft.Json.Utilities.ReflectionObject[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public Newtonsoft.Json.Utilities.ReflectionObject[] s_emptyArray;
    }

    public class List`1
    {
        public int DefaultCapacity;
        public VRC.Localization.LocalizationAssetSource[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public VRC.Localization.LocalizationAssetSource[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public System.ValueTuple`3<...,...,...>[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public System.ValueTuple`3<...,...,...>[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x391B800 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x391BA70
        public void get_Item(){} // RVA: 0x38757A0
        public void set_Item(){} // RVA: 0x3878280
        public void IsCompatibleObject(){} // RVA: 0x38728D0
        public void System.Collections.IList.get_Item(){} // RVA: 0x38758B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3878330
        public void Add(){} // RVA: 0x618500
        public void AddWithResize(){} // RVA: 0x38784B0
        public void System.Collections.IList.Add(){} // RVA: 0x38BC6C0
        public void AddRange(){} // RVA: 0x391BB20
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x391BC60 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x391BCE0
        public void System.Collections.IList.Contains(){} // RVA: 0x391BD50
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x38731E0
        public void Exists(){} // RVA: 0x3875FB0
        public void Find(){} // RVA: 0x3876070
        public void FindAll(){} // RVA: 0x38BCB80
        public void FindIndex(){} // RVA: 0x3876390 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x3876550 | overloaded x2
        public void ForEach(){} // RVA: 0x3876640
        public void GetEnumerator(){} // RVA: 0x3876700
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x3876790
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3876790
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x391C0E0 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x391BF20
        public void Insert(){} // RVA: 0x3878EA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3878FD0
        public void InsertRange(){} // RVA: 0x391C150
        public void LastIndexOf(){} // RVA: 0x391C5C0 | overloaded x3
        public void Remove(){} // RVA: 0x391C690
        public void System.Collections.IList.Remove(){} // RVA: 0x391C7E0
        public void RemoveAll(){} // RVA: 0x38799B0
        public void RemoveAt(){} // RVA: 0x3879B40
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3879C90 | overloaded x2
        public void Sort(){} // RVA: 0x3879F10 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3875010
        public void TrueForAll(){} // RVA: 0x3877C20
        public void AddEnumerable(){} // RVA: 0x391CC30
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public Microsoft.Extensions.Logging.MessageLogger[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public Microsoft.Extensions.Logging.MessageLogger[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x39E7C80 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x39E7EF0
        public void get_Item(){} // RVA: 0x3890760
        public void set_Item(){} // RVA: 0x38907C0
        public void IsCompatibleObject(){} // RVA: 0x38728D0
        public void System.Collections.IList.get_Item(){} // RVA: 0x3890880
        public void System.Collections.IList.set_Item(){} // RVA: 0x39DCC40
        public void Add(){} // RVA: 0x3890A10
        public void AddWithResize(){} // RVA: 0x3890B00
        public void System.Collections.IList.Add(){} // RVA: 0x3890BE0
        public void AddRange(){} // RVA: 0x39E7FA0
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x39E8100 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x39E8190
        public void System.Collections.IList.Contains(){} // RVA: 0x39E8210
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x38731E0
        public void Exists(){} // RVA: 0x38910F0
        public void Find(){} // RVA: 0x38911C0
        public void FindAll(){} // RVA: 0x3932200
        public void FindIndex(){} // RVA: 0x3891520 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x3891700 | overloaded x2
        public void ForEach(){} // RVA: 0x3891800
        public void GetEnumerator(){} // RVA: 0x38918C0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x3891970
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3891970
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x39E85D0 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x39E8400
        public void Insert(){} // RVA: 0x3891D10
        public void System.Collections.IList.Insert(){} // RVA: 0x3891E50
        public void InsertRange(){} // RVA: 0x39E8650
        public void LastIndexOf(){} // RVA: 0x39E8A80 | overloaded x3
        public void Remove(){} // RVA: 0x39E8B60
        public void System.Collections.IList.Remove(){} // RVA: 0x39E8CC0
        public void RemoveAll(){} // RVA: 0x3892820
        public void RemoveAt(){} // RVA: 0x38929E0
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3892B40 | overloaded x2
        public void Sort(){} // RVA: 0x3892DC0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3875010
        public void TrueForAll(){} // RVA: 0x3892E80
        public void AddEnumerable(){} // RVA: 0x39E9120
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public Microsoft.Extensions.Logging.ScopeLogger[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public Microsoft.Extensions.Logging.ScopeLogger[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A4CE50 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A4D0C0
        public void get_Item(){} // RVA: 0x38727E0
        public void set_Item(){} // RVA: 0x3872830
        public void IsCompatibleObject(){} // RVA: 0x38728D0
        public void System.Collections.IList.get_Item(){} // RVA: 0x3872930
        public void System.Collections.IList.set_Item(){} // RVA: 0x3872990
        public void Add(){} // RVA: 0x5BEEC0
        public void AddWithResize(){} // RVA: 0x3872B00
        public void System.Collections.IList.Add(){} // RVA: 0x3872BC0
        public void AddRange(){} // RVA: 0x3A4D170
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A4D2A0 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A4D310
        public void System.Collections.IList.Contains(){} // RVA: 0x3A4D380
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x38731E0
        public void Exists(){} // RVA: 0x3873240
        public void Find(){} // RVA: 0x38732F0
        public void FindAll(){} // RVA: 0x38BB3A0
        public void FindIndex(){} // RVA: 0x3873640 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x3873800 | overloaded x2
        public void ForEach(){} // RVA: 0x38738F0
        public void GetEnumerator(){} // RVA: 0x38739A0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x3873A30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3873A30
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A4D6D0 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A4D530
        public void Insert(){} // RVA: 0x3873E50
        public void System.Collections.IList.Insert(){} // RVA: 0x3873F80
        public void InsertRange(){} // RVA: 0x3A4D740
        public void LastIndexOf(){} // RVA: 0x3A4DB90 | overloaded x3
        public void Remove(){} // RVA: 0x3A4DC50
        public void System.Collections.IList.Remove(){} // RVA: 0x3A4DD70
        public void RemoveAll(){} // RVA: 0x3874860
        public void RemoveAt(){} // RVA: 0x3874A00
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3874BE0 | overloaded x2
        public void Sort(){} // RVA: 0x3874E60 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3875010
        public void TrueForAll(){} // RVA: 0x3875060
        public void AddEnumerable(){} // RVA: 0x3A4E1A0
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public IJobSortable[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public IJobSortable[] s_emptyArray;
    }

    public class List`1
    {
        public int DefaultCapacity;
        public LiteralList[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public LiteralList[] s_emptyArray;
    }

    public class List`1
    {
        public int DefaultCapacity;
        public ZLogger.MessageSequence[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public ZLogger.MessageSequence[] s_emptyArray;
    }

    public class List`1
    {
        public int DefaultCapacity;
        public ÏÍÌÌÌÏÌÍÍÎÎÎÍÍÍÍÍÌÌÏÍÌÎ[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public ÏÍÌÌÌÏÌÍÍÎÎÎÍÍÍÍÍÌÌÏÍÌÎ[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public Cysharp.Threading.Tasks.UniTaskCompletionSource[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public Cysharp.Threading.Tasks.UniTaskCompletionSource[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public UnityEngine.RangeInt[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public UnityEngine.RangeInt[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A1DC60 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A1DED0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x3883BE0
        public void IsCompatibleObject(){} // RVA: 0x38728D0
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883C20
        public void System.Collections.IList.set_Item(){} // RVA: 0x3883C80
        public void Add(){} // RVA: 0x3883D90
        public void AddWithResize(){} // RVA: 0x3883DF0
        public void System.Collections.IList.Add(){} // RVA: 0x3883E60
        public void AddRange(){} // RVA: 0x3A1DF80
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A1E190 | overloaded x3
        public void Clear(){} // RVA: 0x38841E0
        public void Contains(){} // RVA: 0x3A1E1D0
        public void System.Collections.IList.Contains(){} // RVA: 0x3A1E230
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x38731E0
        public void Exists(){} // RVA: 0x38B5740
        public void Find(){} // RVA: 0x38843E0
        public void FindAll(){} // RVA: 0x38B57E0
        public void FindIndex(){} // RVA: 0x3884640 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x38847C0 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A1E550 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A1E3C0
        public void Insert(){} // RVA: 0x3884CB0
        public void System.Collections.IList.Insert(){} // RVA: 0x3884D70
        public void InsertRange(){} // RVA: 0x3A1E5B0
        public void LastIndexOf(){} // RVA: 0x3A1E960 | overloaded x3
        public void Remove(){} // RVA: 0x3A1EA10
        public void System.Collections.IList.Remove(){} // RVA: 0x3A1EAB0
        public void RemoveAll(){} // RVA: 0x3885500
        public void RemoveAt(){} // RVA: 0x3885630
        public void RemoveRange(){} // RVA: 0x3885680
        public void Reverse(){} // RVA: 0x3885830 | overloaded x2
        public void Sort(){} // RVA: 0x3885B90 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3875010
        public void TrueForAll(){} // RVA: 0x3885C50
        public void AddEnumerable(){} // RVA: 0x3A1EE60
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public System.ValueTuple`2<UnityEngine.Transform,bool>[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public System.ValueTuple`2<UnityEngine.Transform,bool>[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x38D6B50 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x38D6DC0
        public void get_Item(){} // RVA: 0x38727E0
        public void set_Item(){} // RVA: 0x3872830
        public void IsCompatibleObject(){} // RVA: 0x38728D0
        public void System.Collections.IList.get_Item(){} // RVA: 0x3872930
        public void System.Collections.IList.set_Item(){} // RVA: 0x3872990
        public void Add(){} // RVA: 0x5BEEC0
        public void AddWithResize(){} // RVA: 0x3872B00
        public void System.Collections.IList.Add(){} // RVA: 0x3893510
        public void AddRange(){} // RVA: 0x38D6E70
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x38D6FA0 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x38D7010
        public void System.Collections.IList.Contains(){} // RVA: 0x38D7080
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x38731E0
        public void Exists(){} // RVA: 0x3873240
        public void Find(){} // RVA: 0x38732F0
        public void FindAll(){} // RVA: 0x3893990
        public void FindIndex(){} // RVA: 0x3873640 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x3873800 | overloaded x2
        public void ForEach(){} // RVA: 0x38738F0
        public void GetEnumerator(){} // RVA: 0x38739A0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x3873A30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3873A30
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x38D73D0 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x38D7230
        public void Insert(){} // RVA: 0x3873E50
        public void System.Collections.IList.Insert(){} // RVA: 0x3873F80
        public void InsertRange(){} // RVA: 0x38D7440
        public void LastIndexOf(){} // RVA: 0x38D7820 | overloaded x3
        public void Remove(){} // RVA: 0x38D78E0
        public void System.Collections.IList.Remove(){} // RVA: 0x38D7A00
        public void RemoveAll(){} // RVA: 0x3874860
        public void RemoveAt(){} // RVA: 0x3874A00
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3874BE0 | overloaded x2
        public void Sort(){} // RVA: 0x3874E60 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3875010
        public void TrueForAll(){} // RVA: 0x3875060
        public void AddEnumerable(){} // RVA: 0x38D7E30
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public System.Collections.Generic.KeyValuePair`2<int,VRC.Dynamics.VRCConstraintGroup>[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public System.Collections.Generic.KeyValuePair`2<int,VRC.Dynamics.VRCConstraintGroup>[] s_emptyArray;
    }

    public class List`1
    {
        public int DefaultCapacity;
        public VRC.SDK3.Avatars.Components.VRCRaycast[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public VRC.SDK3.Avatars.Components.VRCRaycast[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public UnityEngine.UIElements.Panel[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public UnityEngine.UIElements.Panel[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public UnityEngine.UIElements.PanelSettings[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public UnityEngine.UIElements.PanelSettings[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public Steamworks.SteamClass[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public Steamworks.SteamClass[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public Callback[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public Callback[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3AD2450 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3AD26C0
        public void get_Item(){} // RVA: 0x38727E0
        public void set_Item(){} // RVA: 0x3872830
        public void IsCompatibleObject(){} // RVA: 0x38728D0
        public void System.Collections.IList.get_Item(){} // RVA: 0x3872930
        public void System.Collections.IList.set_Item(){} // RVA: 0x3872990
        public void Add(){} // RVA: 0x5BEEC0
        public void AddWithResize(){} // RVA: 0x3872B00
        public void System.Collections.IList.Add(){} // RVA: 0x3872BC0
        public void AddRange(){} // RVA: 0x3AD2770
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3AD28A0 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3AD2910
        public void System.Collections.IList.Contains(){} // RVA: 0x3AD2980
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x38731E0
        public void Exists(){} // RVA: 0x3873240
        public void Find(){} // RVA: 0x38732F0
        public void FindAll(){} // RVA: 0x38BB3A0
        public void FindIndex(){} // RVA: 0x3873640 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x3873800 | overloaded x2
        public void ForEach(){} // RVA: 0x38738F0
        public void GetEnumerator(){} // RVA: 0x38739A0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x3873A30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3873A30
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3AD2CD0 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3AD2B30
        public void Insert(){} // RVA: 0x3873E50
        public void System.Collections.IList.Insert(){} // RVA: 0x3873F80
        public void InsertRange(){} // RVA: 0x3AD2D40
        public void LastIndexOf(){} // RVA: 0x3AD3190 | overloaded x3
        public void Remove(){} // RVA: 0x3AD3250
        public void System.Collections.IList.Remove(){} // RVA: 0x3AD3370
        public void RemoveAll(){} // RVA: 0x3874860
        public void RemoveAt(){} // RVA: 0x3874A00
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3874BE0 | overloaded x2
        public void Sort(){} // RVA: 0x3874E60 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3875010
        public void TrueForAll(){} // RVA: 0x3875060
        public void AddEnumerable(){} // RVA: 0x3AD37A0
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public System.Action`1<UIntPtr>[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public System.Action`1<UIntPtr>[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public System.Threading.Timer[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public System.Threading.Timer[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public ÍÌÏÎÌÏÌÏÌÏÌÌÌÌÌÏÏÏÎÍÎÏÍ[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public ÍÌÏÎÌÏÌÏÌÏÌÌÌÌÌÏÏÏÎÍÎÏÍ[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public ÌÏÎÌÍÏÍÎÌÌÎÎÍÌÎÎÌÍÎÎÎÎÏ[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public ÌÏÎÌÍÏÍÎÌÌÎÎÍÌÎÎÌÍÎÎÎÎÏ[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public ÏÏÌÌÌÏÌÎÌÏÌÌÎÌÏÌÎÏÍÎÎÌÎ[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public ÏÏÌÌÌÏÌÎÌÏÌÌÎÌÏÌÎÏÍÎÎÌÎ[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public ÏÎÏÌÎÎÌÌÏÌÏÏÌÎÍÏÌÌÏÍÎÎÌ[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public ÏÎÏÌÎÎÌÌÏÌÏÏÌÎÍÏÌÌÏÍÎÎÌ[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public Photon.Client.NCommand[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public Photon.Client.NCommand[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public ÎÎÎÍÏÍÌÎÎÏÌÌÌÍÍÎÏÎÌÍÍÏÍ[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public ÎÎÎÍÏÍÌÎÎÏÌÌÌÍÍÎÏÎÌÍÍÏÍ[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public ÌÍÍÏÎÏÌÎÌÎÌÏÏÎÏÌÍÏÌÍÍÍÎ[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public ÌÍÍÏÎÏÌÎÌÎÌÏÏÎÏÌÍÏÌÍÍÍÎ[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public ÏÍÎÎÍÌÍÏÎÌÏÎÏÌÎÍÍÌÌÎÎÎÏ[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public ÏÍÎÎÍÌÍÏÎÌÏÎÏÌÎÍÍÌÌÎÎÎÏ[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public ÌÏÏÏÍÍÏÏÍÏÍÏÌÌÏÎÌÌÏÎÎÎÍ[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public ÌÏÏÏÍÍÏÏÍÏÍÏÌÌÏÎÌÌÏÎÎÎÍ[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public UnityEngine.InputSystem.InputBinding[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public UnityEngine.InputSystem.InputBinding[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x397F210 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x397F480
        public void get_Item(){} // RVA: 0x39173F0
        public void set_Item(){} // RVA: 0x3917470
        public void IsCompatibleObject(){} // RVA: 0x38728D0
        public void System.Collections.IList.get_Item(){} // RVA: 0x39174F0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3917590
        public void Add(){} // RVA: 0x144A790
        public void AddWithResize(){} // RVA: 0x39176E0
        public void System.Collections.IList.Add(){} // RVA: 0x397F530
        public void AddRange(){} // RVA: 0x397F670
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x397F7F0 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x397F870
        public void System.Collections.IList.Contains(){} // RVA: 0x397F910
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x38731E0
        public void Exists(){} // RVA: 0x3917D20
        public void Find(){} // RVA: 0x3917E20
        public void FindAll(){} // RVA: 0x397FAC0
        public void FindIndex(){} // RVA: 0x3918250 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x39184A0 | overloaded x2
        public void ForEach(){} // RVA: 0x39185E0
        public void GetEnumerator(){} // RVA: 0x39186E0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x39187A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x39187A0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x397FF20 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x397FD00
        public void Insert(){} // RVA: 0x3918BE0
        public void System.Collections.IList.Insert(){} // RVA: 0x3918CE0
        public void InsertRange(){} // RVA: 0x397FFD0
        public void LastIndexOf(){} // RVA: 0x3980460 | overloaded x3
        public void Remove(){} // RVA: 0x3980580
        public void System.Collections.IList.Remove(){} // RVA: 0x39806C0
        public void RemoveAll(){} // RVA: 0x3919750
        public void RemoveAt(){} // RVA: 0x3919970
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3919A90 | overloaded x2
        public void Sort(){} // RVA: 0x3919D10 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3875010
        public void TrueForAll(){} // RVA: 0x3919DD0
        public void AddEnumerable(){} // RVA: 0x3980B10
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public UnityEngine.InputSystem.InputActionMap[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public UnityEngine.InputSystem.InputActionMap[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public System.Collections.Generic.List`1<UnityEngine.InputSystem.InputBinding>[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.InputSystem.InputBinding>[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public UnityEngine.InputSystem.InputAction[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public UnityEngine.InputSystem.InputAction[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public System.Collections.Generic.List`1<UnityEngine.InputSystem.InputAction>[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.InputSystem.InputAction>[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public UnityEngine.InputSystem.Utilities.NameAndParameters[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public UnityEngine.InputSystem.Utilities.NameAndParameters[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x39ED5B0 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x39ED820
        public void get_Item(){} // RVA: 0x38757A0
        public void set_Item(){} // RVA: 0x3878280
        public void IsCompatibleObject(){} // RVA: 0x38728D0
        public void System.Collections.IList.get_Item(){} // RVA: 0x38758B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3878330
        public void Add(){} // RVA: 0x618500
        public void AddWithResize(){} // RVA: 0x38784B0
        public void System.Collections.IList.Add(){} // RVA: 0x3878580
        public void AddRange(){} // RVA: 0x39ED8D0
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x39EDA10 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x39EDA90
        public void System.Collections.IList.Contains(){} // RVA: 0x39EDB00
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x38731E0
        public void Exists(){} // RVA: 0x3875FB0
        public void Find(){} // RVA: 0x3876070
        public void FindAll(){} // RVA: 0x392A710
        public void FindIndex(){} // RVA: 0x3876390 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x3876550 | overloaded x2
        public void ForEach(){} // RVA: 0x3876640
        public void GetEnumerator(){} // RVA: 0x3876700
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x3876790
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3876790
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x39EDE90 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x39EDCD0
        public void Insert(){} // RVA: 0x3878EA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3878FD0
        public void InsertRange(){} // RVA: 0x39EDF00
        public void LastIndexOf(){} // RVA: 0x39EE370 | overloaded x3
        public void Remove(){} // RVA: 0x39EE440
        public void System.Collections.IList.Remove(){} // RVA: 0x39EE590
        public void RemoveAll(){} // RVA: 0x38799B0
        public void RemoveAt(){} // RVA: 0x3879B40
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3879C90 | overloaded x2
        public void Sort(){} // RVA: 0x3879F10 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3875010
        public void TrueForAll(){} // RVA: 0x3877C20
        public void AddEnumerable(){} // RVA: 0x39EE9E0
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public ÍÌÏÌÌÏÍÎÌÎÌÌÏÏÌÍÌÎÌÍÏÎÏ[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public ÍÌÏÌÌÏÍÎÌÎÌÌÏÏÌÍÌÎÌÍÏÎÏ[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public UnityEngine.UI.ICanvasElement[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public UnityEngine.UI.ICanvasElement[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public VRC.Udon.Common.Interfaces.IUdonComponentGetterModule[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonComponentGetterModule[] s_emptyArray;
    }

    public class List`1
    {
        public int DefaultCapacity;
        public VRC.Udon.Common.Interfaces.IUdonWrapperModule[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonWrapperModule[] s_emptyArray;
    }

    public class List`1
    {
        public int DefaultCapacity;
        public System.Reflection.MethodBase[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public System.Reflection.MethodBase[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public ScheduledFrameEvent[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public ScheduledFrameEvent[] s_emptyArray;
    }

    public class List`1
    {
        public int DefaultCapacity;
        public ScheduledTimeEvent[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public ScheduledTimeEvent[] s_emptyArray;
    }

    public class List`1
    {
        public int DefaultCapacity;
        public bool[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public bool[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3934780 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x39349F0
        public void get_Item(){} // RVA: 0x3934AA0
        public void set_Item(){} // RVA: 0x3934AE0
        public void IsCompatibleObject(){} // RVA: 0x38728D0
        public void System.Collections.IList.get_Item(){} // RVA: 0x3934B20
        public void System.Collections.IList.set_Item(){} // RVA: 0x3934B80
        public void Add(){} // RVA: 0x3934C90
        public void AddWithResize(){} // RVA: 0x3934CF0
        public void System.Collections.IList.Add(){} // RVA: 0x3934D60
        public void AddRange(){} // RVA: 0x3934E90
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x39350A0 | overloaded x3
        public void Clear(){} // RVA: 0x38841E0
        public void Contains(){} // RVA: 0x39350E0
        public void System.Collections.IList.Contains(){} // RVA: 0x3935140
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x38731E0
        public void Exists(){} // RVA: 0x39352A0
        public void Find(){} // RVA: 0x3935340
        public void FindAll(){} // RVA: 0x39353E0
        public void FindIndex(){} // RVA: 0x39355B0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x3935730 | overloaded x2
        public void ForEach(){} // RVA: 0x3935810
        public void GetEnumerator(){} // RVA: 0x39358B0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x3935940
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3935940
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3935BC0 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3935A30
        public void Insert(){} // RVA: 0x3935C20
        public void System.Collections.IList.Insert(){} // RVA: 0x3935CF0
        public void InsertRange(){} // RVA: 0x3935DE0
        public void LastIndexOf(){} // RVA: 0x39361A0 | overloaded x3
        public void Remove(){} // RVA: 0x3936250
        public void System.Collections.IList.Remove(){} // RVA: 0x39362F0
        public void RemoveAll(){} // RVA: 0x3936490
        public void RemoveAt(){} // RVA: 0x3885630
        public void RemoveRange(){} // RVA: 0x3885680
        public void Reverse(){} // RVA: 0x39366F0 | overloaded x2
        public void Sort(){} // RVA: 0x3936A50 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3875010
        public void TrueForAll(){} // RVA: 0x3936B10
        public void AddEnumerable(){} // RVA: 0x3936BA0
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public System.Collections.Generic.List`1<UnityEngine.Canvas>[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.Canvas>[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public UnityEngine.UI.LayoutRebuilder[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public UnityEngine.UI.LayoutRebuilder[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public System.Collections.Generic.List`1<UnityEngine.Component>[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.Component>[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public System.Collections.Generic.List`1<UnityEngine.UI.RectMask2D>[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.UI.RectMask2D>[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public MatEntry[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public MatEntry[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public VRC.SDKBase.VRCPlayerApi[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public VRC.SDKBase.VRCPlayerApi[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public Handlers[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public Handlers[] s_emptyArray;
    }

    public class List`1
    {
        public int DefaultCapacity;
        public System.Collections.Generic.IReadOnlyDictionary`2<string,object>[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public System.Collections.Generic.IReadOnlyDictionary`2<string,object>[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public Token[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public Token[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3AE6180 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3AE63F0
        public void get_Item(){} // RVA: 0x38757A0
        public void set_Item(){} // RVA: 0x3878280
        public void IsCompatibleObject(){} // RVA: 0x38728D0
        public void System.Collections.IList.get_Item(){} // RVA: 0x38758B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3878330
        public void Add(){} // RVA: 0x618500
        public void AddWithResize(){} // RVA: 0x38784B0
        public void System.Collections.IList.Add(){} // RVA: 0x3878580
        public void AddRange(){} // RVA: 0x3AE64A0
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3AE65E0 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3AE6660
        public void System.Collections.IList.Contains(){} // RVA: 0x3AE66D0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x38731E0
        public void Exists(){} // RVA: 0x3875FB0
        public void Find(){} // RVA: 0x3876070
        public void FindAll(){} // RVA: 0x392A710
        public void FindIndex(){} // RVA: 0x3876390 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x3876550 | overloaded x2
        public void ForEach(){} // RVA: 0x3876640
        public void GetEnumerator(){} // RVA: 0x3876700
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x3876790
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3876790
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3AE6A60 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3AE68A0
        public void Insert(){} // RVA: 0x3878EA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3878FD0
        public void InsertRange(){} // RVA: 0x3AE6AD0
        public void LastIndexOf(){} // RVA: 0x3AE6EE0 | overloaded x3
        public void Remove(){} // RVA: 0x3AE6FB0
        public void System.Collections.IList.Remove(){} // RVA: 0x3AE7100
        public void RemoveAll(){} // RVA: 0x38799B0
        public void RemoveAt(){} // RVA: 0x3879B40
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3879C90 | overloaded x2
        public void Sort(){} // RVA: 0x3879F10 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3875010
        public void TrueForAll(){} // RVA: 0x3877C20
        public void AddEnumerable(){} // RVA: 0x3AE7550
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public ÎÎÎÌÍÌÎÏÎÎÏÏÍÍÏÍÍÏÎÍÎÌÍ[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public ÎÎÎÌÍÌÎÏÎÎÏÏÍÍÏÍÍÏÎÍÎÌÍ[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public ÍÍÏÍÏÌÎÏÏÎÌÏÌÍÏÏÎÌÌÌÎÌÏ[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public ÍÍÏÍÏÌÎÏÏÎÌÏÌÍÏÏÎÌÌÌÎÌÏ[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public ÏÎÌÌÌÌÏÌÍÎÌÌÏÎÍÎÍÏÎÌÎÌÌ[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public ÏÎÌÌÌÌÏÌÍÎÌÌÏÎÍÎÍÏÎÌÎÌÌ[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public ÎÎÎÍÎÏÍÍÏÏÎÌÌÍÎÍÎÌÏÍÏÏÏ[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public ÎÎÎÍÎÏÍÍÏÏÎÌÌÍÎÍÎÌÏÍÏÏÏ[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public ÍÏÎÎÎÏÍÍÍÎÌÎÌÍÌÎÏÌÎÎÌÌÌ[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public ÍÏÎÎÎÏÍÍÍÎÌÎÌÍÌÎÏÌÎÎÌÌÌ[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public System.TimeZoneInfo[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public System.TimeZoneInfo[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public VRC.Dynamics.ChainId[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public VRC.Dynamics.ChainId[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x393EFE0 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x393F250
        public void get_Item(){} // RVA: 0x38727E0
        public void set_Item(){} // RVA: 0x388ABC0
        public void IsCompatibleObject(){} // RVA: 0x38728D0
        public void System.Collections.IList.get_Item(){} // RVA: 0x3872930
        public void System.Collections.IList.set_Item(){} // RVA: 0x388AC10
        public void Add(){} // RVA: 0x388AD20
        public void AddWithResize(){} // RVA: 0x388AD90
        public void System.Collections.IList.Add(){} // RVA: 0x388AE00
        public void AddRange(){} // RVA: 0x393F300
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x393F430 | overloaded x3
        public void Clear(){} // RVA: 0x38841E0
        public void Contains(){} // RVA: 0x393F4A0
        public void System.Collections.IList.Contains(){} // RVA: 0x393F510
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x38731E0
        public void Exists(){} // RVA: 0x3873240
        public void Find(){} // RVA: 0x38732F0
        public void FindAll(){} // RVA: 0x3921A70
        public void FindIndex(){} // RVA: 0x3873640 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x3873800 | overloaded x2
        public void ForEach(){} // RVA: 0x38738F0
        public void GetEnumerator(){} // RVA: 0x38739A0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x3873A30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3873A30
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x393F860 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x393F6C0
        public void Insert(){} // RVA: 0x388B740
        public void System.Collections.IList.Insert(){} // RVA: 0x388B810
        public void InsertRange(){} // RVA: 0x393F8D0
        public void LastIndexOf(){} // RVA: 0x393FD20 | overloaded x3
        public void Remove(){} // RVA: 0x393FDE0
        public void System.Collections.IList.Remove(){} // RVA: 0x393FE90
        public void RemoveAll(){} // RVA: 0x388C070
        public void RemoveAt(){} // RVA: 0x3885630
        public void RemoveRange(){} // RVA: 0x3885680
        public void Reverse(){} // RVA: 0x388C310 | overloaded x2
        public void Sort(){} // RVA: 0x388C670 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3875010
        public void TrueForAll(){} // RVA: 0x3875060
        public void AddEnumerable(){} // RVA: 0x3940240
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public Cinemachine.CinemachineVirtualCameraBase[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public Cinemachine.CinemachineVirtualCameraBase[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public System.Collections.Generic.List`1<Cinemachine.CinemachineVirtualCameraBase>[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public System.Collections.Generic.List`1<Cinemachine.CinemachineVirtualCameraBase>[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public Cinemachine.CinemachineBrain[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public Cinemachine.CinemachineBrain[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public UnityEngine.UIElements.TimeValue[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public UnityEngine.UIElements.TimeValue[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A70CC0 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A70F30
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x3883BE0
        public void IsCompatibleObject(){} // RVA: 0x38728D0
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883C20
        public void System.Collections.IList.set_Item(){} // RVA: 0x3883C80
        public void Add(){} // RVA: 0x3883D90
        public void AddWithResize(){} // RVA: 0x3883DF0
        public void System.Collections.IList.Add(){} // RVA: 0x3883E60
        public void AddRange(){} // RVA: 0x3A70FE0
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A711F0 | overloaded x3
        public void Clear(){} // RVA: 0x38841E0
        public void Contains(){} // RVA: 0x3A71230
        public void System.Collections.IList.Contains(){} // RVA: 0x3A71290
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x38731E0
        public void Exists(){} // RVA: 0x38B5740
        public void Find(){} // RVA: 0x38843E0
        public void FindAll(){} // RVA: 0x38CC060
        public void FindIndex(){} // RVA: 0x3884640 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x38847C0 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A715B0 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A71420
        public void Insert(){} // RVA: 0x3884CB0
        public void System.Collections.IList.Insert(){} // RVA: 0x3884D70
        public void InsertRange(){} // RVA: 0x3A71610
        public void LastIndexOf(){} // RVA: 0x3A719C0 | overloaded x3
        public void Remove(){} // RVA: 0x3A71A70
        public void System.Collections.IList.Remove(){} // RVA: 0x3A71B10
        public void RemoveAll(){} // RVA: 0x3885500
        public void RemoveAt(){} // RVA: 0x3885630
        public void RemoveRange(){} // RVA: 0x3885680
        public void Reverse(){} // RVA: 0x3885830 | overloaded x2
        public void Sort(){} // RVA: 0x3885B90 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3875010
        public void TrueForAll(){} // RVA: 0x3885C50
        public void AddEnumerable(){} // RVA: 0x3A71EC0
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public UnityEngine.UIElements.EasingFunction[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public UnityEngine.UIElements.EasingFunction[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3965DD0 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3966040
        public void get_Item(){} // RVA: 0x3946F00
        public void set_Item(){} // RVA: 0x3946F40
        public void IsCompatibleObject(){} // RVA: 0x38728D0
        public void System.Collections.IList.get_Item(){} // RVA: 0x3946F80
        public void System.Collections.IList.set_Item(){} // RVA: 0x3946FE0
        public void Add(){} // RVA: 0x39470F0
        public void AddWithResize(){} // RVA: 0x3947150
        public void System.Collections.IList.Add(){} // RVA: 0x39471C0
        public void AddRange(){} // RVA: 0x39660F0
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3966300 | overloaded x3
        public void Clear(){} // RVA: 0x38841E0
        public void Contains(){} // RVA: 0x3966340
        public void System.Collections.IList.Contains(){} // RVA: 0x39663A0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x38731E0
        public void Exists(){} // RVA: 0x3947700
        public void Find(){} // RVA: 0x39477A0
        public void FindAll(){} // RVA: 0x3947840
        public void FindIndex(){} // RVA: 0x3947A00 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x3947B80 | overloaded x2
        public void ForEach(){} // RVA: 0x3947C50
        public void GetEnumerator(){} // RVA: 0x3947CF0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x3947D80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3947D80
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x39666B0 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3966530
        public void Insert(){} // RVA: 0x3948050
        public void System.Collections.IList.Insert(){} // RVA: 0x3948110
        public void InsertRange(){} // RVA: 0x3966710
        public void LastIndexOf(){} // RVA: 0x3966AC0 | overloaded x3
        public void Remove(){} // RVA: 0x3966B70
        public void System.Collections.IList.Remove(){} // RVA: 0x3966C10
        public void RemoveAll(){} // RVA: 0x3948890
        public void RemoveAt(){} // RVA: 0x3885630
        public void RemoveRange(){} // RVA: 0x3885680
        public void Reverse(){} // RVA: 0x3948AE0 | overloaded x2
        public void Sort(){} // RVA: 0x3948E40 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3875010
        public void TrueForAll(){} // RVA: 0x3948F00
        public void AddEnumerable(){} // RVA: 0x3966FB0
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public BoolMonitor[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public BoolMonitor[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public UnityEngine.EventSystems.BaseRaycaster[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public UnityEngine.EventSystems.BaseRaycaster[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public Valve.VR.SteamVR_Action[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public Valve.VR.SteamVR_Action[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public Valve.VR.SteamVR_Action_Skeleton[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public Valve.VR.SteamVR_Action_Skeleton[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public Valve.VR.ISteamVR_Action_Out[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public Valve.VR.ISteamVR_Action_Out[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public Valve.VR.ISteamVR_Action_In[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public Valve.VR.ISteamVR_Action_In[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public Valve.VR.SteamVR_Action_Pose[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public Valve.VR.SteamVR_Action_Pose[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public OrderBlock[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public OrderBlock[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3AB9220 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3AB9490
        public void get_Item(){} // RVA: 0x38727E0
        public void set_Item(){} // RVA: 0x387A580
        public void IsCompatibleObject(){} // RVA: 0x38728D0
        public void System.Collections.IList.get_Item(){} // RVA: 0x3872930
        public void System.Collections.IList.set_Item(){} // RVA: 0x387A620
        public void Add(){} // RVA: 0xE7CE50
        public void AddWithResize(){} // RVA: 0x387A790
        public void System.Collections.IList.Add(){} // RVA: 0x387A850
        public void AddRange(){} // RVA: 0x3AB9540
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3AB9670 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3AB96E0
        public void System.Collections.IList.Contains(){} // RVA: 0x3AB9750
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x38731E0
        public void Exists(){} // RVA: 0x3873240
        public void Find(){} // RVA: 0x38732F0
        public void FindAll(){} // RVA: 0x3939F50
        public void FindIndex(){} // RVA: 0x3873640 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x3873800 | overloaded x2
        public void ForEach(){} // RVA: 0x38738F0
        public void GetEnumerator(){} // RVA: 0x38739A0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x3873A30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3873A30
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3AB9AA0 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3AB9900
        public void Insert(){} // RVA: 0x387B0F0
        public void System.Collections.IList.Insert(){} // RVA: 0x387B220
        public void InsertRange(){} // RVA: 0x3AB9B10
        public void LastIndexOf(){} // RVA: 0x3AB9F60 | overloaded x3
        public void Remove(){} // RVA: 0x3ABA020
        public void System.Collections.IList.Remove(){} // RVA: 0x3ABA090
        public void RemoveAll(){} // RVA: 0x387BB70
        public void RemoveAt(){} // RVA: 0x387BD10
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x387BE50 | overloaded x2
        public void Sort(){} // RVA: 0x387C0D0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3875010
        public void TrueForAll(){} // RVA: 0x3875060
        public void AddEnumerable(){} // RVA: 0x3ABA400
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public UIntPtr[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public UIntPtr[] s_emptyArray;
    }

    public class List`1
    {
        public int DefaultCapacity;
        public SteamAudio.SteamAudioSource[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public SteamAudio.SteamAudioSource[] s_emptyArray;
    }

    public class List`1
    {
        public int DefaultCapacity;
        public VRC.Core.Burst.DisposableJobHandle[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public VRC.Core.Burst.DisposableJobHandle[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x39623D0 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3962640
        public void get_Item(){} // RVA: 0x38727E0
        public void set_Item(){} // RVA: 0x388ABC0
        public void IsCompatibleObject(){} // RVA: 0x38728D0
        public void System.Collections.IList.get_Item(){} // RVA: 0x3872930
        public void System.Collections.IList.set_Item(){} // RVA: 0x388AC10
        public void Add(){} // RVA: 0x388AD20
        public void AddWithResize(){} // RVA: 0x388AD90
        public void System.Collections.IList.Add(){} // RVA: 0x388AE00
        public void AddRange(){} // RVA: 0x39626F0
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3962820 | overloaded x3
        public void Clear(){} // RVA: 0x38841E0
        public void Contains(){} // RVA: 0x3962890
        public void System.Collections.IList.Contains(){} // RVA: 0x3962900
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x38731E0
        public void Exists(){} // RVA: 0x3873240
        public void Find(){} // RVA: 0x38732F0
        public void FindAll(){} // RVA: 0x388B2D0
        public void FindIndex(){} // RVA: 0x3873640 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x3873800 | overloaded x2
        public void ForEach(){} // RVA: 0x38738F0
        public void GetEnumerator(){} // RVA: 0x38739A0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x3873A30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3873A30
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3962C50 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3962AB0
        public void Insert(){} // RVA: 0x388B740
        public void System.Collections.IList.Insert(){} // RVA: 0x388B810
        public void InsertRange(){} // RVA: 0x3962CC0
        public void LastIndexOf(){} // RVA: 0x3963110 | overloaded x3
        public void Remove(){} // RVA: 0x39631D0
        public void System.Collections.IList.Remove(){} // RVA: 0x3963280
        public void RemoveAll(){} // RVA: 0x388C070
        public void RemoveAt(){} // RVA: 0x3885630
        public void RemoveRange(){} // RVA: 0x3885680
        public void Reverse(){} // RVA: 0x388C310 | overloaded x2
        public void Sort(){} // RVA: 0x388C670 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3875010
        public void TrueForAll(){} // RVA: 0x3875060
        public void AddEnumerable(){} // RVA: 0x3963630
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public VRC.SDKBase.VRC_SceneDescriptor[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public VRC.SDKBase.VRC_SceneDescriptor[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public UnityEngine.UI.IClipper[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public UnityEngine.UI.IClipper[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public MaskingMaterial[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public MaskingMaterial[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public FallbackMaterial[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public FallbackMaterial[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public UnityEngine.UI.IMaterialModifier[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public UnityEngine.UI.IMaterialModifier[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public UnityEngine.UI.Mask[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public UnityEngine.UI.Mask[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public System.Collections.Generic.List`1<UnityEngine.UI.Mask>[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.UI.Mask>[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public UnityEngine.Color32[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public UnityEngine.Color32[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3946BE0 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3946E50
        public void get_Item(){} // RVA: 0x3946F00
        public void set_Item(){} // RVA: 0x3946F40
        public void IsCompatibleObject(){} // RVA: 0x38728D0
        public void System.Collections.IList.get_Item(){} // RVA: 0x3946F80
        public void System.Collections.IList.set_Item(){} // RVA: 0x3946FE0
        public void Add(){} // RVA: 0x39470F0
        public void AddWithResize(){} // RVA: 0x3947150
        public void System.Collections.IList.Add(){} // RVA: 0x39471C0
        public void AddRange(){} // RVA: 0x39472F0
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3947500 | overloaded x3
        public void Clear(){} // RVA: 0x38841E0
        public void Contains(){} // RVA: 0x3947540
        public void System.Collections.IList.Contains(){} // RVA: 0x39475A0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x38731E0
        public void Exists(){} // RVA: 0x3947700
        public void Find(){} // RVA: 0x39477A0
        public void FindAll(){} // RVA: 0x3947840
        public void FindIndex(){} // RVA: 0x3947A00 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x3947B80 | overloaded x2
        public void ForEach(){} // RVA: 0x3947C50
        public void GetEnumerator(){} // RVA: 0x3947CF0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x3947D80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3947D80
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3947FF0 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3947E70
        public void Insert(){} // RVA: 0x3948050
        public void System.Collections.IList.Insert(){} // RVA: 0x3948110
        public void InsertRange(){} // RVA: 0x3948200
        public void LastIndexOf(){} // RVA: 0x39485B0 | overloaded x3
        public void Remove(){} // RVA: 0x3948660
        public void System.Collections.IList.Remove(){} // RVA: 0x3948700
        public void RemoveAll(){} // RVA: 0x3948890
        public void RemoveAt(){} // RVA: 0x3885630
        public void RemoveRange(){} // RVA: 0x3885680
        public void Reverse(){} // RVA: 0x3948AE0 | overloaded x2
        public void Sort(){} // RVA: 0x3948E40 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3875010
        public void TrueForAll(){} // RVA: 0x3948F00
        public void AddEnumerable(){} // RVA: 0x3948F90
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public System.Collections.Generic.List`1<UnityEngine.Vector3>[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.Vector3>[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public System.Collections.Generic.List`1<UnityEngine.Color32>[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.Color32>[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public System.Collections.Generic.List`1<UnityEngine.Vector4>[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.Vector4>[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public System.Collections.Generic.List`1<int>[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public System.Collections.Generic.List`1<int>[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public System.Collections.Generic.List`1<UnityEngine.UI.IMaterialModifier>[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.UI.IMaterialModifier>[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public System.ValueTuple`2<ÏÎÌÌÌÌÏÌÍÎÌÌÏÎÍÎÍÏÎÌÎÌÌ,bool>[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public System.ValueTuple`2<ÏÎÌÌÌÌÏÌÍÎÌÌÏÎÍÎÍÏÎÌÎÌÌ,bool>[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x38D6B50 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x38D6DC0
        public void get_Item(){} // RVA: 0x38727E0
        public void set_Item(){} // RVA: 0x3872830
        public void IsCompatibleObject(){} // RVA: 0x38728D0
        public void System.Collections.IList.get_Item(){} // RVA: 0x3872930
        public void System.Collections.IList.set_Item(){} // RVA: 0x3872990
        public void Add(){} // RVA: 0x5BEEC0
        public void AddWithResize(){} // RVA: 0x3872B00
        public void System.Collections.IList.Add(){} // RVA: 0x3893510
        public void AddRange(){} // RVA: 0x38D6E70
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x38D6FA0 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x38D7010
        public void System.Collections.IList.Contains(){} // RVA: 0x38D7080
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x38731E0
        public void Exists(){} // RVA: 0x3873240
        public void Find(){} // RVA: 0x38732F0
        public void FindAll(){} // RVA: 0x3893990
        public void FindIndex(){} // RVA: 0x3873640 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x3873800 | overloaded x2
        public void ForEach(){} // RVA: 0x38738F0
        public void GetEnumerator(){} // RVA: 0x38739A0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x3873A30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3873A30
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x38D73D0 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x38D7230
        public void Insert(){} // RVA: 0x3873E50
        public void System.Collections.IList.Insert(){} // RVA: 0x3873F80
        public void InsertRange(){} // RVA: 0x38D7440
        public void LastIndexOf(){} // RVA: 0x38D7820 | overloaded x3
        public void Remove(){} // RVA: 0x38D78E0
        public void System.Collections.IList.Remove(){} // RVA: 0x38D7A00
        public void RemoveAll(){} // RVA: 0x3874860
        public void RemoveAt(){} // RVA: 0x3874A00
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3874BE0 | overloaded x2
        public void Sort(){} // RVA: 0x3874E60 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3875010
        public void TrueForAll(){} // RVA: 0x3875060
        public void AddEnumerable(){} // RVA: 0x38D7E30
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public UnityEngine.XR.XRNodeState[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public UnityEngine.XR.XRNodeState[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A95010 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A95280
        public void get_Item(){} // RVA: 0x39F4670
        public void set_Item(){} // RVA: 0x39F46F0
        public void IsCompatibleObject(){} // RVA: 0x38728D0
        public void System.Collections.IList.get_Item(){} // RVA: 0x39F4780
        public void System.Collections.IList.set_Item(){} // RVA: 0x39F4830
        public void Add(){} // RVA: 0x39F4970
        public void AddWithResize(){} // RVA: 0x39F4A50
        public void System.Collections.IList.Add(){} // RVA: 0x39F4AF0
        public void AddRange(){} // RVA: 0x3A95330
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A954B0 | overloaded x3
        public void Clear(){} // RVA: 0x38841E0
        public void Contains(){} // RVA: 0x3A95530
        public void System.Collections.IList.Contains(){} // RVA: 0x3A955D0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x38731E0
        public void Exists(){} // RVA: 0x39F5080
        public void Find(){} // RVA: 0x39F5190
        public void FindAll(){} // RVA: 0x39F52F0
        public void FindIndex(){} // RVA: 0x39F55C0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x39F5810 | overloaded x2
        public void ForEach(){} // RVA: 0x39F5950
        public void GetEnumerator(){} // RVA: 0x39F5A50
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x39F5B10
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x39F5B10
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A95A10 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A957F0
        public void Insert(){} // RVA: 0x39F5F50
        public void System.Collections.IList.Insert(){} // RVA: 0x39F6050
        public void InsertRange(){} // RVA: 0x3A95AC0
        public void LastIndexOf(){} // RVA: 0x3A95F50 | overloaded x3
        public void Remove(){} // RVA: 0x3A96070
        public void System.Collections.IList.Remove(){} // RVA: 0x3A96150
        public void RemoveAll(){} // RVA: 0x39F6A00
        public void RemoveAt(){} // RVA: 0x3885630
        public void RemoveRange(){} // RVA: 0x3885680
        public void Reverse(){} // RVA: 0x39F6E10 | overloaded x2
        public void Sort(){} // RVA: 0x39F7240 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3875010
        public void TrueForAll(){} // RVA: 0x39F7300
        public void AddEnumerable(){} // RVA: 0x3A96540
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public ÌÌÎÍÎÎÌÌÎÌÏÏÎÍÍÎÎÏÍÏÌÎÍ[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public ÌÌÎÍÎÎÌÌÎÌÏÏÎÍÍÎÎÏÍÏÌÎÍ[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public BestHTTP.Extensions.BufferStore[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public BestHTTP.Extensions.BufferStore[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x39398B0 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3939B20
        public void get_Item(){} // RVA: 0x38727E0
        public void set_Item(){} // RVA: 0x387A580
        public void IsCompatibleObject(){} // RVA: 0x38728D0
        public void System.Collections.IList.get_Item(){} // RVA: 0x3872930
        public void System.Collections.IList.set_Item(){} // RVA: 0x387A620
        public void Add(){} // RVA: 0xE7CE50
        public void AddWithResize(){} // RVA: 0x387A790
        public void System.Collections.IList.Add(){} // RVA: 0x387A850
        public void AddRange(){} // RVA: 0x3939BD0
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3939D00 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3939D70
        public void System.Collections.IList.Contains(){} // RVA: 0x3939DE0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x38731E0
        public void Exists(){} // RVA: 0x3873240
        public void Find(){} // RVA: 0x38732F0
        public void FindAll(){} // RVA: 0x3939F50
        public void FindIndex(){} // RVA: 0x3873640 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x3873800 | overloaded x2
        public void ForEach(){} // RVA: 0x38738F0
        public void GetEnumerator(){} // RVA: 0x38739A0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x3873A30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3873A30
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x393A280 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x393A0E0
        public void Insert(){} // RVA: 0x387B0F0
        public void System.Collections.IList.Insert(){} // RVA: 0x387B220
        public void InsertRange(){} // RVA: 0x393A2F0
        public void LastIndexOf(){} // RVA: 0x393A740 | overloaded x3
        public void Remove(){} // RVA: 0x393A800
        public void System.Collections.IList.Remove(){} // RVA: 0x393A870
        public void RemoveAll(){} // RVA: 0x387BB70
        public void RemoveAt(){} // RVA: 0x387BD10
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x387BE50 | overloaded x2
        public void Sort(){} // RVA: 0x387C0D0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3875010
        public void TrueForAll(){} // RVA: 0x3875060
        public void AddEnumerable(){} // RVA: 0x393ABE0
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public IJobSortable[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public IJobSortable[] s_emptyArray;
    }

    public class List`1
    {
        public int DefaultCapacity;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ServerName[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.ServerName[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public VRC.InventoryEffects.InventoryEffectAssetReference[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public VRC.InventoryEffects.InventoryEffectAssetReference[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public UnityEngine.ParticleSystemRenderer[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public UnityEngine.ParticleSystemRenderer[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class List`1
    {
        public int DefaultCapacity;
        public ÍÍÍÎÏÌÌÎÌÏÏÍÌÎÎÎÏÌÌÎÍÎÌ[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public ÍÍÍÎÏÌÌÎÌÏÏÍÌÎÎÎÏÌÌÎÍÎÌ[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

}