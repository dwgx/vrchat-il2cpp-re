// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections
// Classes: 14
// Methods: 149

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections
{
    public class CollectionUtilities : Object
    {
        // ── Methods ──
        public void AddRange(){} // RVA: 0x7FFE8A149B10
        public void CheckElementsAreOfType(){} // RVA: 0x7FFE8A149D90
        public void ReadOnly(){} // RVA: 0x7FFE8A14A050 | overloaded x3
        public void RequireNext(){} // RVA: 0x7FFE8A14A0E0
        public void ToString(){} // RVA: 0x7FFE8A14A180
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class EmptyEnumerable : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void GetEnumerator(){} // RVA: 0x7FFE8A14A4A0
        public void .cctor(){} // RVA: 0x7FFE8A14A500
    }

    public class EmptyEnumerator : Object
    {
        public System.Collections.IEnumerator Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void MoveNext(){} // RVA: 0x7FFE810FB320
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void get_Current(){} // RVA: 0x7FFE8A14A5A0
        public void .cctor(){} // RVA: 0x7FFE8A14A5F0
    }

    public class EnumerableProxy : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A14A690
        public void GetEnumerator(){} // RVA: 0x7FFE8A14A740
    }

    public class HashSet : Object
    {
        public System.Collections.IDictionary impl; // 0x10
        public object field_1; // 0x114
        public object field_2; // 0x115
        public object field_3; // 0x116
        public object field_4; // 0x117
        public object field_5; // 0x118

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A14A870 | overloaded x2
        public void Add(){} // RVA: 0x7FFE8A14AB20
        public void AddAll(){} // RVA: 0x7FFE8A14AB90
        public void Clear(){} // RVA: 0x7FFE8A14AD80
        public void Contains(){} // RVA: 0x7FFE8A14ADD0
        public void CopyTo(){} // RVA: 0x7FFE8A14AE30
        public void get_Count(){} // RVA: 0x7FFE8A14AEC0
        public void GetEnumerator(){} // RVA: 0x7FFE8A14AF10
        public void get_IsEmpty(){} // RVA: 0x7FFE8A14AF90
        public void get_IsFixedSize(){} // RVA: 0x7FFE8A14AFF0
        public void get_IsReadOnly(){} // RVA: 0x7FFE8A14B040
        public void get_IsSynchronized(){} // RVA: 0x7FFE8A14B090
        public void Remove(){} // RVA: 0x7FFE8A14B0E0
        public void RemoveAll(){} // RVA: 0x7FFE8A14B140
        public void get_SyncRoot(){} // RVA: 0x7FFE8A14B330
    }

    public class ISet
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE80E460A0
        public void AddAll(){} // RVA: 0x7FFE80E460A0
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Contains(){} // RVA: 0x7FFE80E2F3B0
        public void get_IsEmpty(){} // RVA: 0x7FFE80E2F150
        public void get_IsFixedSize(){} // RVA: 0x7FFE80E2F150
        public void get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void Remove(){} // RVA: 0x7FFE80E460A0
        public void RemoveAll(){} // RVA: 0x7FFE80E460A0
    }

    public class LinkedDictionary : Object
    {
        public System.Collections.IDictionary hash; // 0x10
        public System.Collections.IList keys; // 0x18
        public object field_2; // 0x11D
        public object field_3; // 0x11E
        public object field_4; // 0x11F
        public object field_5; // 0x120
        public object field_6; // 0x121
        public object field_7; // 0x122

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A14B380
        public void Add(){} // RVA: 0x7FFE8A14B510
        public void Clear(){} // RVA: 0x7FFE8A14B5B0
        public void Contains(){} // RVA: 0x7FFE8A14B630
        public void CopyTo(){} // RVA: 0x7FFE8A14B690
        public void get_Count(){} // RVA: 0x7FFE8A14B960
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8A14B9B0
        public void GetEnumerator(){} // RVA: 0x7FFE8A14B9D0
        public void Remove(){} // RVA: 0x7FFE8A14BA70
        public void get_IsFixedSize(){} // RVA: 0x7FFE810FB320
        public void get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void get_SyncRoot(){} // RVA: 0x7FFE8A14BB00
        public void get_Keys(){} // RVA: 0x7FFE8A14BBE0
        public void get_Values(){} // RVA: 0x7FFE8A14BC80
        public void get_Item(){} // RVA: 0x7FFE8A14C060
        public void set_Item(){} // RVA: 0x7FFE8A14C0C0
    }

    public class LinkedDictionaryEnumerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.LinkedDictionary parent; // 0x10
        public int pos; // 0x18
        public object field_2; // 0x125
        public object field_3; // 0x126
        public object field_4; // 0x127

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE83C3D9B0
        public void get_Current(){} // RVA: 0x7FFE8A14C180
        public void get_Entry(){} // RVA: 0x7FFE8A14C1F0
        public void get_Key(){} // RVA: 0x7FFE8A14C290
        public void MoveNext(){} // RVA: 0x7FFE8A14C2A0
        public void Reset(){} // RVA: 0x7FFE82A55FE0
        public void get_Value(){} // RVA: 0x7FFE8A14C350
        public void get_CurrentKey(){} // RVA: 0x7FFE8A14C3C0
    }

    public class UnmodifiableDictionary : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Add(){} // RVA: 0x7FFE8A14C4B0
        public void Clear(){} // RVA: 0x7FFE8A14C4F0
        public void Contains(){} // RVA: 0x7FFE80E2F3B0
        public void CopyTo(){} // RVA: 0x7FFE80E4D070
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8A14B9B0
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void Remove(){} // RVA: 0x7FFE8A14C530
        public void get_IsFixedSize(){} // RVA: 0x7FFE80E2F150
        public void get_IsReadOnly(){} // RVA: 0x7FFE811E0850
        public void get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
        public void get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void get_Item(){} // RVA: 0x7FFE87741860
        public void set_Item(){} // RVA: 0x7FFE8A14C570
        public void GetValue(){} // RVA: 0x7FFE80E2E390
    }

    public class UnmodifiableDictionaryProxy : UnmodifiableDictionary
    {
        public System.Collections.IDictionary d; // 0x10
        public object field_1; // 0x132
        public object field_2; // 0x133
        public object field_3; // 0x134
        public object field_4; // 0x135
        public object field_5; // 0x136

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Contains(){} // RVA: 0x7FFE8A14C5B0
        public void CopyTo(){} // RVA: 0x7FFE8A14C610
        public void get_Count(){} // RVA: 0x7FFE8A14C680
        public void GetEnumerator(){} // RVA: 0x7FFE8A14C6D0
        public void get_IsFixedSize(){} // RVA: 0x7FFE8A14C720
        public void get_IsSynchronized(){} // RVA: 0x7FFE8A14C770
        public void get_SyncRoot(){} // RVA: 0x7FFE8A14C7C0
        public void get_Keys(){} // RVA: 0x7FFE8A14C810
        public void get_Values(){} // RVA: 0x7FFE8A14C860
        public void GetValue(){} // RVA: 0x7FFE8A14C8B0
    }

    public class UnmodifiableList : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Add(){} // RVA: 0x7FFE8A14C910
        public void Clear(){} // RVA: 0x7FFE8A14C950
        public void Contains(){} // RVA: 0x7FFE80E2F3B0
        public void CopyTo(){} // RVA: 0x7FFE80E4D070
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void IndexOf(){} // RVA: 0x7FFE80E33B00
        public void Insert(){} // RVA: 0x7FFE8A14C990
        public void get_IsFixedSize(){} // RVA: 0x7FFE80E2F150
        public void get_IsReadOnly(){} // RVA: 0x7FFE811E0850
        public void get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
        public void Remove(){} // RVA: 0x7FFE8A14C9D0
        public void RemoveAt(){} // RVA: 0x7FFE8A14CA10
        public void get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void get_Item(){} // RVA: 0x7FFE8A14CA50
        public void set_Item(){} // RVA: 0x7FFE8A14CA70
        public void GetValue(){} // RVA: 0x7FFE80E3D230
    }

    public class UnmodifiableListProxy : UnmodifiableList
    {
        public System.Collections.IList l; // 0x10
        public object field_1; // 0x13E
        public object field_2; // 0x13F
        public object field_3; // 0x140

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Contains(){} // RVA: 0x7FFE8A14CAB0
        public void CopyTo(){} // RVA: 0x7FFE8A14CB10
        public void get_Count(){} // RVA: 0x7FFE8A14CB80
        public void GetEnumerator(){} // RVA: 0x7FFE8A14CBD0
        public void IndexOf(){} // RVA: 0x7FFE8A14CC20
        public void get_IsFixedSize(){} // RVA: 0x7FFE8A14CC80
        public void get_IsSynchronized(){} // RVA: 0x7FFE8A14CCD0
        public void get_SyncRoot(){} // RVA: 0x7FFE8A14CD20
        public void GetValue(){} // RVA: 0x7FFE8A14CD70
    }

    public class UnmodifiableSet : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Add(){} // RVA: 0x7FFE8A14CDD0
        public void AddAll(){} // RVA: 0x7FFE8A14CE10
        public void Clear(){} // RVA: 0x7FFE8A14CE50
        public void Contains(){} // RVA: 0x7FFE80E2F3B0
        public void CopyTo(){} // RVA: 0x7FFE80E4D070
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void get_IsEmpty(){} // RVA: 0x7FFE80E2F150
        public void get_IsFixedSize(){} // RVA: 0x7FFE80E2F150
        public void get_IsReadOnly(){} // RVA: 0x7FFE811E0850
        public void get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
        public void get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void Remove(){} // RVA: 0x7FFE8A14CE90
        public void RemoveAll(){} // RVA: 0x7FFE8A14CED0
    }

    public class UnmodifiableSetProxy : UnmodifiableSet
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet s; // 0x10
        public object field_1; // 0x148
        public object field_2; // 0x149
        public object field_3; // 0x14A
        public object field_4; // 0x14B

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Contains(){} // RVA: 0x7FFE8A14CF10
        public void CopyTo(){} // RVA: 0x7FFE8A14CF70
        public void get_Count(){} // RVA: 0x7FFE8A14CFE0
        public void GetEnumerator(){} // RVA: 0x7FFE8A14D030
        public void get_IsEmpty(){} // RVA: 0x7FFE8A14D080
        public void get_IsFixedSize(){} // RVA: 0x7FFE8A14D0D0
        public void get_IsSynchronized(){} // RVA: 0x7FFE8A14D120
        public void get_SyncRoot(){} // RVA: 0x7FFE8A14D170
    }

}