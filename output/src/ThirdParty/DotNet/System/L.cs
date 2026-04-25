// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 10
// Methods: 57

namespace ThirdParty.DotNet.System
{
    public class LazyDebugView`1 : Object
    {
    }

    public class LazyHelper : Object
    {
        public System.LazyHelper State;
        public System.LazyHelper NoneViaFactory; // 0x8
        public System.LazyHelper PublicationOnlyViaConstructor; // 0x10
        public System.LazyHelper PublicationOnlyViaFactory; // 0x18
        public System.LazyHelper PublicationOnlyWaitForOtherThreadToPublish; // 0x20
        public 0x6B0C0050 <State>k__BackingField; // 0x10
        public System.Runtime.ExceptionServices.ExceptionDispatchInfo _exceptionDispatch; // 0x18

        // ── Methods ──
        public void get_State(){} // RVA: 0x7FFAC2F6E5C0
        public void .ctor(){} // RVA: 0x7FFAC8632A70 | overloaded x2
        public void ThrowException(){} // RVA: 0x7FFAC8632BB0
        public void Create(){} // RVA: 0x7FFAC8632BD0
        public void CreateViaDefaultConstructor(){} // RVA: 0x7FFAC8632D70
        public void GetModeFromIsThreadSafe(){} // RVA: 0x7FFAC8632DE0
        public void .cctor(){} // RVA: 0x7FFAC8632DF0
    }

    public class Lazy`1 : Object
    {
        public System.LazyHelper IsValueCreated;
        public System.Func`1<T> Value;
        public T _value;

        // ── Methods ──
        public void CreateViaDefaultConstructor(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C77970 | overloaded x6
        public void ViaConstructor(){} // RVA: 0x7FFAC2C70980
        public void ViaFactory(){} // RVA: 0x7FFAC2C70ED0
        public void ExecutionAndPublication(){} // RVA: 0x7FFAC2C76500
        public void PublicationOnly(){} // RVA: 0x7FFAC2E8DC40
        public void PublicationOnlyViaConstructor(){} // RVA: 0x7FFAC2C70A40
        public void PublicationOnlyViaFactory(){} // RVA: 0x7FFAC2C70A40
        public void PublicationOnlyWaitForOtherThreadToPublish(){} // RVA: 0x7FFAC2C70980
        public void CreateValue(){} // RVA: 0x7FFAC2E8DC40
        public void ToString(){} // RVA: 0x7FFAC2C58E90
        public void get_IsValueCreated(){} // RVA: 0x7FFAC2C59D00
        public void get_Value(){} // RVA: 0x7FFAC2E8DC40
    }

    public class LocalAppContext : Object
    {
        public bool DisableCaching;
        public bool s_disableCaching; // 0x1
        public object s_syncObject; // 0x8

        // ── Methods ──
        public void GetCachedSwitchValue(){} // RVA: 0x7FFAC8E597F0
        public void GetCachedSwitchValueInternal(){} // RVA: 0x7FFAC8E59810
        public void get_DisableCaching(){} // RVA: 0x7FFAC8E598A0
    }

    public class LocalAppContextSwitches : Object
    {
        public bool MemberDescriptorEqualsReturnsFalseIfEquivalent;
    }

    public class LocalDataStore : Object
    {
        public System.LocalDataStoreElement[] m_DataTable; // 0x10
        public System.LocalDataStoreMgr m_Manager; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8668AF0
        public void Dispose(){} // RVA: 0x7FFAC8668BF0
        public void GetData(){} // RVA: 0x7FFAC8668C20
        public void SetData(){} // RVA: 0x7FFAC8668D50
        public void FreeData(){} // RVA: 0x7FFAC8668EE0
        public void PopulateElement(){} // RVA: 0x7FFAC8668F40
    }

    public class LocalDataStoreElement : Object
    {
        public object Value; // 0x10
        public long Cookie; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC38920D0
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void get_Cookie(){} // RVA: 0x7FFAC2F247C0
    }

    public class LocalDataStoreHolder : Object
    {
        public System.LocalDataStore Store; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Finalize(){} // RVA: 0x7FFAC8668A90
        public void get_Store(){} // RVA: 0x7FFAC2F3C380
    }

    public class LocalDataStoreMgr : Object
    {
        public int InitialSlotTableSize;
        public int SlotTableDoubleThreshold;
        public int LargeSlotTableSizeIncrease;
        public bool[] m_SlotInfoTable; // 0x10
        public int m_FirstAvailableSlot; // 0x18
        public System.Collections.Generic.List`1<System.LocalDataStore> m_ManagedLocalDataStores; // 0x20
        public System.Collections.Generic.Dictionary`2<string,System.LocalDataStoreSlot> m_KeyToSlotMap; // 0x28
        public long m_CookieGenerator; // 0x30

        // ── Methods ──
        public void CreateLocalDataStore(){} // RVA: 0x7FFAC86694B0
        public void DeleteLocalDataStore(){} // RVA: 0x7FFAC8669820
        public void AllocateDataSlot(){} // RVA: 0x7FFAC8669990
        public void AllocateNamedDataSlot(){} // RVA: 0x7FFAC8669E70
        public void GetNamedDataSlot(){} // RVA: 0x7FFAC866A050
        public void FreeNamedDataSlot(){} // RVA: 0x7FFAC866A260
        public void FreeDataSlot(){} // RVA: 0x7FFAC866A3D0
        public void ValidateSlot(){} // RVA: 0x7FFAC866A650
        public void GetSlotTableLength(){} // RVA: 0x7FFAC3510620
        public void .ctor(){} // RVA: 0x7FFAC866A6D0
    }

    public class LocalDataStoreSlot : Object
    {
        public System.LocalDataStoreMgr Manager; // 0x10
        public int Slot; // 0x18
        public long Cookie; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86693E0
        public void get_Manager(){} // RVA: 0x7FFAC2F3C380
        public void get_Slot(){} // RVA: 0x7FFAC3157800
        public void get_Cookie(){} // RVA: 0x7FFAC2F4F0C0
        public void Finalize(){} // RVA: 0x7FFAC8669450
    }

}