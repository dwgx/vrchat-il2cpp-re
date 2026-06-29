// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections
// Classes: 14
// Methods: 146

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections
{
    public class CollectionUtilities : Object
    {
        // ── Methods ──
        public void AddRange(){} // RVA: 0xA38C7A0
        public void CheckElementsAreOfType(){} // RVA: 0xA38CA10
        public void ReadOnly(){} // RVA: 0xA38CCC0
        public void RequireNext(){} // RVA: 0xA38CD50
        public void ToString(){} // RVA: 0xA38CDF0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class EmptyEnumerable : Object
    {
        public object Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void GetEnumerator(){} // RVA: 0xA38D120
        public void .cctor(){} // RVA: 0xA38D180
    }

    public class EmptyEnumerator : Object
    {
        public object Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void MoveNext(){} // RVA: 0xB43320
        public void Reset(){} // RVA: 0xB43310
        public void get_Current(){} // RVA: 0xA38D220
        public void .cctor(){} // RVA: 0xA38D270
    }

    public class EnumerableProxy : Object
    {
        public object inner;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA38D310
        public void GetEnumerator(){} // RVA: 0xA38D3C0
    }

    public class HashSet : Object
    {
        public object impl;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA38D4F0
        public void Add(){} // RVA: 0xA38D790
        public void AddAll(){} // RVA: 0xA38D800
        public void Clear(){} // RVA: 0xA38D9D0
        public void Contains(){} // RVA: 0xA38DA20
        public void CopyTo(){} // RVA: 0xA38DA80
        public void get_Count(){} // RVA: 0xA38DB10
        public void GetEnumerator(){} // RVA: 0xA38DB60
        public void get_IsEmpty(){} // RVA: 0xA38DBE0
        public void get_IsFixedSize(){} // RVA: 0xA38DC40
        public void get_IsReadOnly(){} // RVA: 0xA38DC90
        public void get_IsSynchronized(){} // RVA: 0xA38DCE0
        public void Remove(){} // RVA: 0xA38DD30
        public void RemoveAll(){} // RVA: 0xA38DD90
        public void get_SyncRoot(){} // RVA: 0xA38DF60
    }

    public class ISet
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x894320
        public void AddAll(){} // RVA: 0x894320
        public void Clear(){} // RVA: 0x894290
        public void Contains(){} // RVA: 0x87D350
        public void get_IsEmpty(){} // RVA: 0x87D280
        public void get_IsFixedSize(){} // RVA: 0x87D280
        public void get_IsReadOnly(){} // RVA: 0x87D280
        public void Remove(){} // RVA: 0x894320
        public void RemoveAll(){} // RVA: 0x894320
    }

    public class LinkedDictionary : Object
    {
        public object hash;
        public object keys;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA38DFB0
        public void Add(){} // RVA: 0xA38E140
        public void Clear(){} // RVA: 0xA38E1E0
        public void Contains(){} // RVA: 0xA38E260
        public void CopyTo(){} // RVA: 0xA38E2C0
        public void get_Count(){} // RVA: 0xA38E570
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x5BD4800
        public void GetEnumerator(){} // RVA: 0xA38E5C0
        public void Remove(){} // RVA: 0xA38E660
        public void get_IsFixedSize(){} // RVA: 0xB43320
        public void get_IsReadOnly(){} // RVA: 0xB43320
        public void get_IsSynchronized(){} // RVA: 0xB43320
        public void get_SyncRoot(){} // RVA: 0xA38E6F0
        public void get_Keys(){} // RVA: 0xA38E7B0
        public void get_Values(){} // RVA: 0xA38E850
        public void get_Item(){} // RVA: 0xA38EC20
        public void set_Item(){} // RVA: 0xA38EC80
    }

    public class LinkedDictionaryEnumerator : Object
    {
        public object parent;
        public object pos;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x39EC7C0
        public void get_Current(){} // RVA: 0xA38ED40
        public void get_Entry(){} // RVA: 0xA38EDB0
        public void get_Key(){} // RVA: 0xA38EE50
        public void MoveNext(){} // RVA: 0xA38EE60
        public void Reset(){} // RVA: 0x2576860
        public void get_Value(){} // RVA: 0xA38EF10
        public void get_CurrentKey(){} // RVA: 0xA38EF80
    }

    public class UnmodifiableDictionary : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Add(){} // RVA: 0xA38F070
        public void Clear(){} // RVA: 0xA38F0B0
        public void Contains(){} // RVA: 0x87D350
        public void CopyTo(){} // RVA: 0x899290
        public void get_Count(){} // RVA: 0x87C130
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x5BD4800
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void Remove(){} // RVA: 0xA38F0F0
        public void get_IsFixedSize(){} // RVA: 0x87D280
        public void get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void get_IsSynchronized(){} // RVA: 0x87D280
        public void get_SyncRoot(){} // RVA: 0x87C0A0
        public void get_Keys(){} // RVA: 0x87C0A0
        public void get_Values(){} // RVA: 0x87C0A0
        public void get_Item(){} // RVA: 0x7661BC0
        public void set_Item(){} // RVA: 0xA38F130
        public void GetValue(){} // RVA: 0x87C540
    }

    public class UnmodifiableDictionaryProxy : UnmodifiableDictionary
    {
        public object d;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Contains(){} // RVA: 0xA38F170
        public void CopyTo(){} // RVA: 0xA38F1D0
        public void get_Count(){} // RVA: 0xA38F240
        public void GetEnumerator(){} // RVA: 0xA38F290
        public void get_IsFixedSize(){} // RVA: 0xA38F2E0
        public void get_IsSynchronized(){} // RVA: 0xA38F330
        public void get_SyncRoot(){} // RVA: 0xA38F380
        public void get_Keys(){} // RVA: 0xA38F3D0
        public void get_Values(){} // RVA: 0xA38F420
        public void GetValue(){} // RVA: 0xA38F470
    }

    public class UnmodifiableList : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Add(){} // RVA: 0xA38F4D0
        public void Clear(){} // RVA: 0xA38F510
        public void Contains(){} // RVA: 0x87D350
        public void CopyTo(){} // RVA: 0x899290
        public void get_Count(){} // RVA: 0x87C130
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void IndexOf(){} // RVA: 0x87D050
        public void Insert(){} // RVA: 0xA38F550
        public void get_IsFixedSize(){} // RVA: 0x87D280
        public void get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void get_IsSynchronized(){} // RVA: 0x87D280
        public void Remove(){} // RVA: 0xA38F590
        public void RemoveAt(){} // RVA: 0xA38F5D0
        public void get_SyncRoot(){} // RVA: 0x87C0A0
        public void get_Item(){} // RVA: 0xA38F610
        public void set_Item(){} // RVA: 0xA38F630
        public void GetValue(){} // RVA: 0x87C160
    }

    public class UnmodifiableListProxy : UnmodifiableList
    {
        public object l;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Contains(){} // RVA: 0xA38F670
        public void CopyTo(){} // RVA: 0xA38F6D0
        public void get_Count(){} // RVA: 0xA38F740
        public void GetEnumerator(){} // RVA: 0xA38F790
        public void IndexOf(){} // RVA: 0xA38F7E0
        public void get_IsFixedSize(){} // RVA: 0xA38F840
        public void get_IsSynchronized(){} // RVA: 0xA38F890
        public void get_SyncRoot(){} // RVA: 0xA38F8E0
        public void GetValue(){} // RVA: 0xA38F930
    }

    public class UnmodifiableSet : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Add(){} // RVA: 0xA38F990
        public void AddAll(){} // RVA: 0xA38F9D0
        public void Clear(){} // RVA: 0xA38FA10
        public void Contains(){} // RVA: 0x87D350
        public void CopyTo(){} // RVA: 0x899290
        public void get_Count(){} // RVA: 0x87C130
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void get_IsEmpty(){} // RVA: 0x87D280
        public void get_IsFixedSize(){} // RVA: 0x87D280
        public void get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void get_IsSynchronized(){} // RVA: 0x87D280
        public void get_SyncRoot(){} // RVA: 0x87C0A0
        public void Remove(){} // RVA: 0xA38FA50
        public void RemoveAll(){} // RVA: 0xA38FA90
    }

    public class UnmodifiableSetProxy : UnmodifiableSet
    {
        public object s;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Contains(){} // RVA: 0xA38FAD0
        public void CopyTo(){} // RVA: 0xA38FB30
        public void get_Count(){} // RVA: 0xA38FBA0
        public void GetEnumerator(){} // RVA: 0xA38FBF0
        public void get_IsEmpty(){} // RVA: 0xA38FC40
        public void get_IsFixedSize(){} // RVA: 0xA38FC90
        public void get_IsSynchronized(){} // RVA: 0xA38FCE0
        public void get_SyncRoot(){} // RVA: 0xA38FD30
    }

}