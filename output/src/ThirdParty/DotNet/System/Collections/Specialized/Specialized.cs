// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Specialized
// Classes: 12
// Methods: 138

namespace ThirdParty.DotNet.System.Collections.Specialized
{
    public class BitVector32 : ValueType
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7A7E9E800
        public void set_Item(){} // RVA: 0x7A7E9E820
        public void CreateMask(){} // RVA: 0x7AEAA39B0
        public void Equals(){} // RVA: 0x7A7E9E840
        public void GetHashCode(){} // RVA: 0x7A7E9E8D0
        public void ToString(){} // RVA: 0x7A7E9E930
    }

    public class CaseSensitiveStringDictionary : StringDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEAA8950
        public void Add(){} // RVA: 0x7AEAA9A10
    }

    public class CompatibleComparer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void Equals(){} // RVA: 0x7AEAAD030
        public void GetHashCode(){} // RVA: 0x7AEAAD150
        public void get_Comparer(){} // RVA: 0x7A80F2570
        public void get_HashCodeProvider(){} // RVA: 0x7A80DA7B0
        public void get_DefaultComparer(){} // RVA: 0x7AEAAD230
        public void get_DefaultHashCodeProvider(){} // RVA: 0x7AEAAD430
    }

    public class ListDictionary : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81052D0
        public void get_Item(){} // RVA: 0x7AEAA3DF0
        public void set_Item(){} // RVA: 0x7AEAA3F30
        public void get_Count(){} // RVA: 0x7A9739200
        public void get_Keys(){} // RVA: 0x7AEAA40E0
        public void get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void get_SyncRoot(){} // RVA: 0x7AEAA4180
        public void get_Values(){} // RVA: 0x7AEAA4230
        public void Add(){} // RVA: 0x7AEAA42D0
        public void Clear(){} // RVA: 0x7ADBE8CA0
        public void Contains(){} // RVA: 0x7AEAA4550
        public void CopyTo(){} // RVA: 0x7AEAA4680
        public void GetEnumerator(){} // RVA: 0x7AEAA4910
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AEAA4970
        public void Remove(){} // RVA: 0x7AEAA49D0
    }

    public class NameObjectCollectionBase : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80FF440
        public void GetObjectData(){} // RVA: 0x7AEAA9EC0
        public void OnDeserialization(){} // RVA: 0x7AEAAAC20
        public void Reset(){} // RVA: 0x7AEAAB8C0
        public void FindEntry(){} // RVA: 0x7AEAABA90
        public void get_IsReadOnly(){} // RVA: 0x7A81A2200
        public void BaseAdd(){} // RVA: 0x7AEAABB50
        public void BaseRemove(){} // RVA: 0x7AEAABD60
        public void BaseGet(){} // RVA: 0x7AEAAC130
        public void BaseSet(){} // RVA: 0x7AEAAC020
        public void BaseGetKey(){} // RVA: 0x7AEAAC1D0
        public void GetEnumerator(){} // RVA: 0x7AEAAC270
        public void get_Count(){} // RVA: 0x7ADA52F20
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AEAAC2D0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AEAAC620
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void BaseGetAllKeys(){} // RVA: 0x7AEAAC6D0
        public void .cctor(){} // RVA: 0x7AEAAC820
    }

    public class NameValueCollection : NameObjectCollectionBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEAA6430
        public void InvalidateCachedArrays(){} // RVA: 0x7AEAA57E0
        public void GetAsOneString(){} // RVA: 0x7AEAA5890
        public void GetAsStringArray(){} // RVA: 0x7AEAA5B00
        public void Add(){} // RVA: 0x7AEAA5BB0
        public void Get(){} // RVA: 0x7AEAA6130
        public void GetValues(){} // RVA: 0x7AEAA61D0
        public void Set(){} // RVA: 0x7AEAA5E70
        public void Remove(){} // RVA: 0x7AEAA60E0
        public void get_Item(){} // RVA: 0x7AE3D58D0
        public void set_Item(){} // RVA: 0x7AEAA6110
        public void GetKey(){} // RVA: 0x7AEAA6270
        public void get_AllKeys(){} // RVA: 0x7AEAA6280
    }

    public class NotifyCollectionChangedEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEAA9090
        public void InitializeAddOrRemove(){} // RVA: 0x7AEAA9270
        public void InitializeAdd(){} // RVA: 0x7AEAA92A0
        public void InitializeRemove(){} // RVA: 0x7AEAA93D0
        public void InitializeMoveOrReplace(){} // RVA: 0x7AEAA9500
    }

    public class NotifyCollectionChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A98B8320
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class OrderedDictionary : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80FF440
        public void get_Count(){} // RVA: 0x7AEAA6540
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80FD690
        public void get_IsReadOnly(){} // RVA: 0x7A80FD690
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void get_Keys(){} // RVA: 0x7AEAA6580
        public void get_objectsArray(){} // RVA: 0x7AEAA6630
        public void get_objectsTable(){} // RVA: 0x7AEAA66F0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AEAA67C0
        public void get_Item(){} // RVA: 0x7AEAA6870
        public void set_Item(){} // RVA: 0x7AEAA68B0
        public void get_Values(){} // RVA: 0x7AEAA6B60
        public void Add(){} // RVA: 0x7AEAA6C10
        public void Clear(){} // RVA: 0x7AEAA6D50
        public void Contains(){} // RVA: 0x7AEAA6E00
        public void CopyTo(){} // RVA: 0x7AEAA6E40
        public void IndexOfKey(){} // RVA: 0x7AEAA6E90
        public void Remove(){} // RVA: 0x7AEAA7000
        public void GetEnumerator(){} // RVA: 0x7AEAA7140
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AEAA7210
        public void GetObjectData(){} // RVA: 0x7AEAA72E0
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7AEAA7580
        public void OnDeserialization(){} // RVA: 0x7AEAA75A0
    }

    public class ReadOnlyList : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_Count(){} // RVA: 0x7AEAA9560
        public void get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void get_IsFixedSize(){} // RVA: 0x7A81BD750
        public void get_IsSynchronized(){} // RVA: 0x7AEAA95B0
        public void get_Item(){} // RVA: 0x7AEAA9600
        public void set_Item(){} // RVA: 0x7AEAA9660
        public void get_SyncRoot(){} // RVA: 0x7AEAA96B0
        public void Add(){} // RVA: 0x7AEAA9700
        public void Clear(){} // RVA: 0x7AEAA9750
        public void Contains(){} // RVA: 0x7AEAA97A0
        public void CopyTo(){} // RVA: 0x7AEAA9800
        public void GetEnumerator(){} // RVA: 0x7AEAA9870
        public void IndexOf(){} // RVA: 0x7AEAA98C0
        public void Insert(){} // RVA: 0x7AEAA9920
        public void Remove(){} // RVA: 0x7AEAA9970
        public void RemoveAt(){} // RVA: 0x7AEAA99C0
    }

    public class StringCollection : Object
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7AEAA8400
        public void set_Item(){} // RVA: 0x7AEAA8490
        public void get_Count(){} // RVA: 0x7ADBEAB80
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void Add(){} // RVA: 0x7AEAA84C0
        public void Clear(){} // RVA: 0x7AE562190
        public void Contains(){} // RVA: 0x7ADBEB120
        public void CopyTo(){} // RVA: 0x7ADBEAE60
        public void IndexOf(){} // RVA: 0x7ADBEB3C0
        public void Insert(){} // RVA: 0x7AEAA84F0
        public void get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void Remove(){} // RVA: 0x7AE92D600
        public void RemoveAt(){} // RVA: 0x7AEAA8520
        public void get_SyncRoot(){} // RVA: 0x7ADBEAE30
        public void System.Collections.IList.get_Item(){} // RVA: 0x7AEAA8400
        public void System.Collections.IList.set_Item(){} // RVA: 0x7AEAA8550
        public void System.Collections.IList.Add(){} // RVA: 0x7AEAA85E0
        public void System.Collections.IList.Contains(){} // RVA: 0x7AEAA8670
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7AEAA8700
        public void System.Collections.IList.Insert(){} // RVA: 0x7AEAA8790
        public void System.Collections.IList.Remove(){} // RVA: 0x7AEAA8820
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ADBEAE60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AD9BABB0
        public void .ctor(){} // RVA: 0x7AEAA88B0
    }

    public class StringDictionary : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEAA8950
        public void Add(){} // RVA: 0x7AEAA8A00
        public void GetEnumerator(){} // RVA: 0x7AE562190
    }

}