// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections
// Classes: 16
// Methods: 135

namespace ThirdParty.DotNet.System.Collections
{
    public class ArrayList : Object
    {
        public object[] Capacity; // 0x10
        public int Count; // 0x18
        public int IsFixedSize; // 0x1C
        public object IsReadOnly; // 0x20
        public int IsSynchronized;
        public int SyncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD539BC350 | overloaded x3
        public void set_Capacity(){} // RVA: 0x7FFD539BC520
        public void get_Count(){} // RVA: 0x7FFD4E577800
        public void get_IsFixedSize(){} // RVA: 0x7FFD4E341320
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E341320
        public void get_IsSynchronized(){} // RVA: 0x7FFD4E341320
        public void get_SyncRoot(){} // RVA: 0x7FFD539BC630
        public void get_Item(){} // RVA: 0x7FFD539BC6E0
        public void set_Item(){} // RVA: 0x7FFD539BC790
        public void Adapter(){} // RVA: 0x7FFD539BC880
        public void Add(){} // RVA: 0x7FFD539BC930
        public void AddRange(){} // RVA: 0x7FFD539BCA10
        public void Clear(){} // RVA: 0x7FFD519091E0
        public void Clone(){} // RVA: 0x7FFD539BCA30
        public void Contains(){} // RVA: 0x7FFD539BCAD0
        public void CopyTo(){} // RVA: 0x7FFD539BCC90 | overloaded x3
        public void EnsureCapacity(){} // RVA: 0x7FFD539BCD80
        public void GetEnumerator(){} // RVA: 0x7FFD539BCDE0
        public void IndexOf(){} // RVA: 0x7FFD539BCE40
        public void Insert(){} // RVA: 0x7FFD539BCE70
        public void InsertRange(){} // RVA: 0x7FFD539BCFB0
        public void ReadOnly(){} // RVA: 0x7FFD539BD190
        public void Remove(){} // RVA: 0x7FFD539BD240
        public void RemoveAt(){} // RVA: 0x7FFD539BD290
        public void RemoveRange(){} // RVA: 0x7FFD539BD360
        public void Reverse(){} // RVA: 0x7FFD539BD5B0 | overloaded x2
        public void Sort(){} // RVA: 0x7FFD539BD790 | overloaded x2
        public void ToArray(){} // RVA: 0x7FFD539BD990 | overloaded x2
    }

    public class Comparer : Object
    {
        public System.Globalization.CompareInfo _compareInfo; // 0x10
        public System.Collections.Comparer Default;
        public System.Collections.Comparer DefaultInvariant; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD539B0480 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFD539B0660
        public void Compare(){} // RVA: 0x7FFD539B0700
        public void .cctor(){} // RVA: 0x7FFD539B08C0
    }

    public class DictionaryEntry : ValueType
    {
        public object Key; // 0x10
        public object Value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F5CE4B0
        public void get_Key(){} // RVA: 0x7FFD4EEF9F60
        public void get_Value(){} // RVA: 0x7FFD4F840220
    }

    public class HashHelpers : Object
    {
        public int[] SerializationInfoTable;
        public System.Runtime.CompilerServices.ConditionalWeakTable`2<object,System.Runtime.Serialization.SerializationInfo> s_serializationInfoTable; // 0x8

        // ── Methods ──
        public void IsPrime(){} // RVA: 0x7FFD539B0C40
        public void GetPrime(){} // RVA: 0x7FFD539B0CF0
        public void ExpandPrime(){} // RVA: 0x7FFD539B0F10
        public void get_SerializationInfoTable(){} // RVA: 0x7FFD539B0F90
        public void .cctor(){} // RVA: 0x7FFD539B10D0
    }

    public class Hashtable : Object
    {
        public int SerializationInfoTable;
        public int Item;
        public string IsReadOnly;
        public string IsFixedSize;
        public string IsSynchronized;
        public string Keys;
        public string Values;
        public string SyncRoot;
        public string Count;
        public string KeyComparerName;
        public bucket[] _buckets; // 0x10
        public int _count; // 0x18
        public int _occupancy; // 0x1C
        public int _loadsize; // 0x20
        public float _loadFactor; // 0x24
        public int _version; // 0x28
        public bool _isWriterInProgress; // 0x2C
        public System.Collections.ICollection _keys; // 0x30
        public System.Collections.ICollection _values; // 0x38
        public System.Collections.IEqualityComparer _keycomparer; // 0x40
        public object _syncRoot; // 0x48
        public System.Runtime.CompilerServices.ConditionalWeakTable`2<object,System.Runtime.Serialization.SerializationInfo> s_serializationInfoTable;

        // ── Methods ──
        public void get_SerializationInfoTable(){} // RVA: 0x7FFD539C01B0
        public void .ctor(){} // RVA: 0x7FFD539C0B90 | overloaded x13
        public void InitHash(){} // RVA: 0x7FFD539C0C00
        public void Add(){} // RVA: 0x7FFD539C0C50
        public void Clear(){} // RVA: 0x7FFD539C0C70
        public void Clone(){} // RVA: 0x7FFD539C0E50
        public void Contains(){} // RVA: 0x7FFD539C0F60
        public void ContainsKey(){} // RVA: 0x7FFD539C0F80
        public void CopyKeys(){} // RVA: 0x7FFD539C1120
        public void CopyEntries(){} // RVA: 0x7FFD539C11C0
        public void CopyTo(){} // RVA: 0x7FFD539C12C0
        public void CopyValues(){} // RVA: 0x7FFD539C1560
        public void get_Item(){} // RVA: 0x7FFD539C1600
        public void set_Item(){} // RVA: 0x7FFD539C1880
        public void expand(){} // RVA: 0x7FFD539C18A0
        public void rehash(){} // RVA: 0x7FFD539C1970 | overloaded x2
        public void UpdateVersion(){} // RVA: 0x7FFD539C1950
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD539C1B10
        public void GetEnumerator(){} // RVA: 0x7FFD539C1BD0
        public void GetHash(){} // RVA: 0x7FFD539C1C90
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E341320
        public void get_IsFixedSize(){} // RVA: 0x7FFD4E341320
        public void get_IsSynchronized(){} // RVA: 0x7FFD4E341320
        public void KeyEquals(){} // RVA: 0x7FFD539C1D20
        public void get_Keys(){} // RVA: 0x7FFD539C1E00
        public void get_Values(){} // RVA: 0x7FFD539C1F00
        public void Insert(){} // RVA: 0x7FFD539C2000
        public void putEntry(){} // RVA: 0x7FFD539C2630
        public void Remove(){} // RVA: 0x7FFD539C2800
        public void get_SyncRoot(){} // RVA: 0x7FFD539C2B00
        public void get_Count(){} // RVA: 0x7FFD4E577800
        public void Synchronized(){} // RVA: 0x7FFD539C2BB0
        public void GetObjectData(){} // RVA: 0x7FFD539C2CA0
        public void OnDeserialization(){} // RVA: 0x7FFD539C37A0
    }

    public class HashtableExtensions : Object
    {
        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x7FFD4E07D5A0
    }

    public class ICollection
    {
        public object Count;
        public object SyncRoot;
        public object IsSynchronized;

        // ── Methods ──
        public void CopyTo(){} // RVA: 0x7FFD4E097970
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_SyncRoot(){} // RVA: 0x7FFD4E078E90
        public void get_IsSynchronized(){} // RVA: 0x7FFD4E079D00
    }

    public class IComparer
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFD4E0837A0
    }

    public class IDictionary
    {
        public object Item;
        public object Keys;
        public object Values;
        public object IsReadOnly;
        public object IsFixedSize;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFD4E078F40
        public void set_Item(){} // RVA: 0x7FFD4E099B30
        public void get_Keys(){} // RVA: 0x7FFD4E078E90
        public void get_Values(){} // RVA: 0x7FFD4E078E90
        public void Contains(){} // RVA: 0x7FFD4E079F60
        public void Add(){} // RVA: 0x7FFD4E099B30
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void get_IsFixedSize(){} // RVA: 0x7FFD4E079D00
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void Remove(){} // RVA: 0x7FFD4E090A40
    }

    public class IDictionaryEnumerator
    {
        public object Key;
        public object Value;
        public object Entry;

        // ── Methods ──
        public void get_Key(){} // RVA: 0x7FFD4E078E90
        public void get_Value(){} // RVA: 0x7FFD4E078E90
        public void get_Entry(){} // RVA: 0x7FFD4E0788A0
    }

    public class IEnumerable
    {
        // ── Methods ──
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class IEnumerator
    {
        public object Current;

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFD4E079D00
        public void get_Current(){} // RVA: 0x7FFD4E078E90
        public void Reset(){} // RVA: 0x7FFD4E090980
    }

    public class IEqualityComparer
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E07D200
        public void GetHashCode(){} // RVA: 0x7FFD4E07E6B0
    }

    public class IList
    {
        public object Item;
        public object IsReadOnly;
        public object IsFixedSize;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFD4E087DE0
        public void set_Item(){} // RVA: 0x7FFD4E092BC0
        public void Add(){} // RVA: 0x7FFD4E07E6B0
        public void Contains(){} // RVA: 0x7FFD4E079F60
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void get_IsFixedSize(){} // RVA: 0x7FFD4E079D00
        public void IndexOf(){} // RVA: 0x7FFD4E07E6B0
        public void Insert(){} // RVA: 0x7FFD4E092BC0
        public void Remove(){} // RVA: 0x7FFD4E090A40
        public void RemoveAt(){} // RVA: 0x7FFD4E090ED0
    }

    public class IStructuralComparable
    {
        // ── Methods ──
        public void CompareTo(){} // RVA: 0x7FFD4E0837A0
    }

    public class IStructuralEquatable
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E07D200
        public void GetHashCode(){} // RVA: 0x7FFD4E07E6B0
    }

}