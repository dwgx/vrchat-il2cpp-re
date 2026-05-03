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
        public System.LazyHelper NoneViaConstructor;

        // ── Methods ──
        public void get_State(){} // RVA: 0x7FFE811485C0
        public void .ctor(){} // RVA: 0x7FFE869DC240 | overloaded x2
        public void ThrowException(){} // RVA: 0x7FFE869DC380
        public void Create(){} // RVA: 0x7FFE869DC3A0
        public void CreateViaDefaultConstructor(){} // RVA: 0x7FFE869DC540
        public void GetModeFromIsThreadSafe(){} // RVA: 0x7FFE869DC5B0
        public void .cctor(){} // RVA: 0x7FFE869DC5C0
    }

    public class Lazy`1 : Object
    {
        public System.LazyHelper _state;
        public System.Func`1<T> _factory;

        // ── Methods ──
        public void CreateViaDefaultConstructor(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E4D070 | overloaded x6
        public void ViaConstructor(){} // RVA: 0x7FFE80E45FE0
        public void ViaFactory(){} // RVA: 0x7FFE80E46530
        public void ExecutionAndPublication(){} // RVA: 0x7FFE80E4BC00
        public void PublicationOnly(){} // RVA: 0x7FFE810A1420
        public void PublicationOnlyViaConstructor(){} // RVA: 0x7FFE80E460A0
        public void PublicationOnlyViaFactory(){} // RVA: 0x7FFE80E460A0
        public void PublicationOnlyWaitForOtherThreadToPublish(){} // RVA: 0x7FFE80E45FE0
        public void CreateValue(){} // RVA: 0x7FFE810A1420
        public void ToString(){} // RVA: 0x7FFE80E2E2E0
        public void get_IsValueCreated(){} // RVA: 0x7FFE80E2F150
        public void get_Value(){} // RVA: 0x7FFE810A1420
    }

    public class LocalAppContext : Object
    {
        public bool s_isDisableCachingInitialized;

        // ── Methods ──
        public void GetCachedSwitchValue(){} // RVA: 0x7FFE87201C20
        public void GetCachedSwitchValueInternal(){} // RVA: 0x7FFE87201C40
        public void get_DisableCaching(){} // RVA: 0x7FFE87201CD0
    }

    public class LocalAppContextSwitches : Object
    {
    }

    public class LocalDataStore : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A122E0
        public void Dispose(){} // RVA: 0x7FFE86A123E0
        public void GetData(){} // RVA: 0x7FFE86A12410
        public void SetData(){} // RVA: 0x7FFE86A12540
        public void FreeData(){} // RVA: 0x7FFE86A126D0
        public void PopulateElement(){} // RVA: 0x7FFE86A12730
    }

    public class LocalDataStoreElement : Object
    {
        public object m_value; // 0x10
        public long m_cookie; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE819EA910
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void get_Cookie(){} // RVA: 0x7FFE810FE7C0
    }

    public class LocalDataStoreHolder : Object
    {
        public System.LocalDataStore m_Store; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Finalize(){} // RVA: 0x7FFE86A12280
        public void get_Store(){} // RVA: 0x7FFE81116380
    }

    public class LocalDataStoreMgr : Object
    {
        // ── Methods ──
        public void CreateLocalDataStore(){} // RVA: 0x7FFE86A12CA0
        public void DeleteLocalDataStore(){} // RVA: 0x7FFE86A13010
        public void AllocateDataSlot(){} // RVA: 0x7FFE86A13180
        public void AllocateNamedDataSlot(){} // RVA: 0x7FFE86A13660
        public void GetNamedDataSlot(){} // RVA: 0x7FFE86A13840
        public void FreeNamedDataSlot(){} // RVA: 0x7FFE86A13A50
        public void FreeDataSlot(){} // RVA: 0x7FFE86A13BC0
        public void ValidateSlot(){} // RVA: 0x7FFE86A13E40
        public void GetSlotTableLength(){} // RVA: 0x7FFE81CCB610
        public void .ctor(){} // RVA: 0x7FFE86A13EC0
    }

    public class LocalDataStoreSlot : Object
    {
        public System.LocalDataStoreMgr m_mgr; // 0x10
        public int m_slot; // 0x18
        public long m_cookie; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A12BD0
        public void get_Manager(){} // RVA: 0x7FFE81116380
        public void get_Slot(){} // RVA: 0x7FFE813DB630
        public void get_Cookie(){} // RVA: 0x7FFE811290C0
        public void Finalize(){} // RVA: 0x7FFE86A12C40
    }

}