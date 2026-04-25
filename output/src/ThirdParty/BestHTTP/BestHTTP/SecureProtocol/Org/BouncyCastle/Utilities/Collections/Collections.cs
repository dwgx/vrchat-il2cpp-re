// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections
// Classes: 14
// Methods: 149

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections
{
    public class CollectionUtilities : Object
    {
        // ── Methods ──
        public void AddRange(){} // RVA: 0x7FFACBCF04F0
        public void CheckElementsAreOfType(){} // RVA: 0x7FFACBCF0770
        public void ReadOnly(){} // RVA: 0x7FFACBCF0A30 | overloaded x3
        public void RequireNext(){} // RVA: 0x7FFACBCF0AC0
        public void ToString(){} // RVA: 0x7FFACBCF0B60
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class EmptyEnumerable : Object
    {
        public System.Collections.IEnumerable Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void GetEnumerator(){} // RVA: 0x7FFACBCF0E80
        public void .cctor(){} // RVA: 0x7FFACBCF0EE0
    }

    public class EmptyEnumerator : Object
    {
        public System.Collections.IEnumerator Current;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFAC2F21320
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void get_Current(){} // RVA: 0x7FFACBCF0F80
        public void .cctor(){} // RVA: 0x7FFACBCF0FD0
    }

    public class EnumerableProxy : Object
    {
        public System.Collections.IEnumerable inner; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCF1070
        public void GetEnumerator(){} // RVA: 0x7FFACBCF1120
    }

    public class HashSet : Object
    {
        public System.Collections.IDictionary Count; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCF1250 | overloaded x2
        public void Add(){} // RVA: 0x7FFACBCF1500
        public void AddAll(){} // RVA: 0x7FFACBCF1570
        public void Clear(){} // RVA: 0x7FFACBCF1760
        public void Contains(){} // RVA: 0x7FFACBCF17B0
        public void CopyTo(){} // RVA: 0x7FFACBCF1810
        public void get_Count(){} // RVA: 0x7FFACBCF18A0
        public void GetEnumerator(){} // RVA: 0x7FFACBCF18F0
        public void get_IsEmpty(){} // RVA: 0x7FFACBCF1970
        public void get_IsFixedSize(){} // RVA: 0x7FFACBCF19D0
        public void get_IsReadOnly(){} // RVA: 0x7FFACBCF1A20
        public void get_IsSynchronized(){} // RVA: 0x7FFACBCF1A70
        public void Remove(){} // RVA: 0x7FFACBCF1AC0
        public void RemoveAll(){} // RVA: 0x7FFACBCF1B20
        public void get_SyncRoot(){} // RVA: 0x7FFACBCF1D10
    }

    public class ISet
    {
        public object IsEmpty;
        public object IsFixedSize;
        public object IsReadOnly;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC2C70A40
        public void AddAll(){} // RVA: 0x7FFAC2C70A40
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Contains(){} // RVA: 0x7FFAC2C59F60
        public void get_IsEmpty(){} // RVA: 0x7FFAC2C59D00
        public void get_IsFixedSize(){} // RVA: 0x7FFAC2C59D00
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void Remove(){} // RVA: 0x7FFAC2C70A40
        public void RemoveAll(){} // RVA: 0x7FFAC2C70A40
    }

    public class LinkedDictionary : Object
    {
        public System.Collections.IDictionary Count; // 0x10
        public System.Collections.IList IsFixedSize; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCF1D60
        public void Add(){} // RVA: 0x7FFACBCF1EF0
        public void Clear(){} // RVA: 0x7FFACBCF1F90
        public void Contains(){} // RVA: 0x7FFACBCF2010
        public void CopyTo(){} // RVA: 0x7FFACBCF2070
        public void get_Count(){} // RVA: 0x7FFACBCF2340
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFACBCF2390
        public void GetEnumerator(){} // RVA: 0x7FFACBCF23B0
        public void Remove(){} // RVA: 0x7FFACBCF2450
        public void get_IsFixedSize(){} // RVA: 0x7FFAC2F21320
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void get_SyncRoot(){} // RVA: 0x7FFACBCF24E0
        public void get_Keys(){} // RVA: 0x7FFACBCF25C0
        public void get_Values(){} // RVA: 0x7FFACBCF2660
        public void get_Item(){} // RVA: 0x7FFACBCF2A40
        public void set_Item(){} // RVA: 0x7FFACBCF2AA0
    }

    public class LinkedDictionaryEnumerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.LinkedDictionary Current; // 0x10
        public int Entry; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC5923EB0
        public void get_Current(){} // RVA: 0x7FFACBCF2B60
        public void get_Entry(){} // RVA: 0x7FFACBCF2BD0
        public void get_Key(){} // RVA: 0x7FFACBCF2C70
        public void MoveNext(){} // RVA: 0x7FFACBCF2C80
        public void Reset(){} // RVA: 0x7FFAC47EDC40
        public void get_Value(){} // RVA: 0x7FFACBCF2D30
        public void get_CurrentKey(){} // RVA: 0x7FFACBCF2DA0
    }

    public class UnmodifiableDictionary : Object
    {
        public object Count;
        public object IsFixedSize;
        public object IsReadOnly;
        public object IsSynchronized;
        public object SyncRoot;
        public object Keys;
        public object Values;
        public object Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Add(){} // RVA: 0x7FFACBCF2E90
        public void Clear(){} // RVA: 0x7FFACBCF2ED0
        public void Contains(){} // RVA: 0x7FFAC2C59F60
        public void CopyTo(){} // RVA: 0x7FFAC2C77970
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFACBCF2390
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void Remove(){} // RVA: 0x7FFACBCF2F10
        public void get_IsFixedSize(){} // RVA: 0x7FFAC2C59D00
        public void get_IsReadOnly(){} // RVA: 0x7FFAC3006850
        public void get_IsSynchronized(){} // RVA: 0x7FFAC2C59D00
        public void get_SyncRoot(){} // RVA: 0x7FFAC2C58E90
        public void get_Keys(){} // RVA: 0x7FFAC2C58E90
        public void get_Values(){} // RVA: 0x7FFAC2C58E90
        public void get_Item(){} // RVA: 0x7FFAC9399130
        public void set_Item(){} // RVA: 0x7FFACBCF2F50
        public void GetValue(){} // RVA: 0x7FFAC2C58F40
    }

    public class UnmodifiableDictionaryProxy : UnmodifiableDictionary
    {
        public System.Collections.IDictionary Count; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Contains(){} // RVA: 0x7FFACBCF2F90
        public void CopyTo(){} // RVA: 0x7FFACBCF2FF0
        public void get_Count(){} // RVA: 0x7FFACBCF3060
        public void GetEnumerator(){} // RVA: 0x7FFACBCF30B0
        public void get_IsFixedSize(){} // RVA: 0x7FFACBCF3100
        public void get_IsSynchronized(){} // RVA: 0x7FFACBCF3150
        public void get_SyncRoot(){} // RVA: 0x7FFACBCF31A0
        public void get_Keys(){} // RVA: 0x7FFACBCF31F0
        public void get_Values(){} // RVA: 0x7FFACBCF3240
        public void GetValue(){} // RVA: 0x7FFACBCF3290
    }

    public class UnmodifiableList : Object
    {
        public object Count;
        public object IsFixedSize;
        public object IsReadOnly;
        public object IsSynchronized;
        public object SyncRoot;
        public object Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Add(){} // RVA: 0x7FFACBCF32F0
        public void Clear(){} // RVA: 0x7FFACBCF3330
        public void Contains(){} // RVA: 0x7FFAC2C59F60
        public void CopyTo(){} // RVA: 0x7FFAC2C77970
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void IndexOf(){} // RVA: 0x7FFAC2C5E6B0
        public void Insert(){} // RVA: 0x7FFACBCF3370
        public void get_IsFixedSize(){} // RVA: 0x7FFAC2C59D00
        public void get_IsReadOnly(){} // RVA: 0x7FFAC3006850
        public void get_IsSynchronized(){} // RVA: 0x7FFAC2C59D00
        public void Remove(){} // RVA: 0x7FFACBCF33B0
        public void RemoveAt(){} // RVA: 0x7FFACBCF33F0
        public void get_SyncRoot(){} // RVA: 0x7FFAC2C58E90
        public void get_Item(){} // RVA: 0x7FFACBCF3430
        public void set_Item(){} // RVA: 0x7FFACBCF3450
        public void GetValue(){} // RVA: 0x7FFAC2C67DE0
    }

    public class UnmodifiableListProxy : UnmodifiableList
    {
        public System.Collections.IList Count; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Contains(){} // RVA: 0x7FFACBCF3490
        public void CopyTo(){} // RVA: 0x7FFACBCF34F0
        public void get_Count(){} // RVA: 0x7FFACBCF3560
        public void GetEnumerator(){} // RVA: 0x7FFACBCF35B0
        public void IndexOf(){} // RVA: 0x7FFACBCF3600
        public void get_IsFixedSize(){} // RVA: 0x7FFACBCF3660
        public void get_IsSynchronized(){} // RVA: 0x7FFACBCF36B0
        public void get_SyncRoot(){} // RVA: 0x7FFACBCF3700
        public void GetValue(){} // RVA: 0x7FFACBCF3750
    }

    public class UnmodifiableSet : Object
    {
        public object Count;
        public object IsEmpty;
        public object IsFixedSize;
        public object IsReadOnly;
        public object IsSynchronized;
        public object SyncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Add(){} // RVA: 0x7FFACBCF37B0
        public void AddAll(){} // RVA: 0x7FFACBCF37F0
        public void Clear(){} // RVA: 0x7FFACBCF3830
        public void Contains(){} // RVA: 0x7FFAC2C59F60
        public void CopyTo(){} // RVA: 0x7FFAC2C77970
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void get_IsEmpty(){} // RVA: 0x7FFAC2C59D00
        public void get_IsFixedSize(){} // RVA: 0x7FFAC2C59D00
        public void get_IsReadOnly(){} // RVA: 0x7FFAC3006850
        public void get_IsSynchronized(){} // RVA: 0x7FFAC2C59D00
        public void get_SyncRoot(){} // RVA: 0x7FFAC2C58E90
        public void Remove(){} // RVA: 0x7FFACBCF3870
        public void RemoveAll(){} // RVA: 0x7FFACBCF38B0
    }

    public class UnmodifiableSetProxy : UnmodifiableSet
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet Count; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Contains(){} // RVA: 0x7FFACBCF38F0
        public void CopyTo(){} // RVA: 0x7FFACBCF3950
        public void get_Count(){} // RVA: 0x7FFACBCF39C0
        public void GetEnumerator(){} // RVA: 0x7FFACBCF3A10
        public void get_IsEmpty(){} // RVA: 0x7FFACBCF3A60
        public void get_IsFixedSize(){} // RVA: 0x7FFACBCF3AB0
        public void get_IsSynchronized(){} // RVA: 0x7FFACBCF3B00
        public void get_SyncRoot(){} // RVA: 0x7FFACBCF3B50
    }

}