// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 10
// Methods: 57

namespace ThirdParty.DotNet.System
{
    public class LazyDebugView`1
    {
    }

    public class LazyHelper
    {
        // ── Methods ──
        public void get_State(){} // RVA: 0x32A5C0
        public void .ctor(){} // RVA: 0x5E9B400 | overloaded x2
        public void ThrowException(){} // RVA: 0x5E9B540
        public void Create(){} // RVA: 0x5E9B560
        public void CreateViaDefaultConstructor(){} // RVA: 0x5E9B700
        public void GetModeFromIsThreadSafe(){} // RVA: 0x5E9B770
        public void .cctor(){} // RVA: 0x5E9B780
    }

    public class Lazy`1
    {
        // ── Methods ──
        public void CreateViaDefaultConstructor(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x2BAA0 | overloaded x6
        public void ViaConstructor(){} // RVA: 0x24A50
        public void ViaFactory(){} // RVA: 0x24FA0
        public void ExecutionAndPublication(){} // RVA: 0x2A620
        public void PublicationOnly(){} // RVA: 0x283FA0
        public void PublicationOnlyViaConstructor(){} // RVA: 0x24B10
        public void PublicationOnlyViaFactory(){} // RVA: 0x24B10
        public void PublicationOnlyWaitForOtherThreadToPublish(){} // RVA: 0x24A50
        public void CreateValue(){} // RVA: 0x283FA0
        public void ToString(){} // RVA: 0xCD60
        public void get_IsValueCreated(){} // RVA: 0xDBE0
        public void get_Value(){} // RVA: 0x283FA0
    }

    public class LocalAppContext
    {
        public object AllowDBNull;

        // ── Methods ──
        public void GetCachedSwitchValue(){} // RVA: 0x66C2D30
        public void GetCachedSwitchValueInternal(){} // RVA: 0x66C2D50
        public void get_DisableCaching(){} // RVA: 0x66C2DE0
    }

    public class LocalAppContextSwitches
    {
    }

    public class LocalDataStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5ED1440
        public void Dispose(){} // RVA: 0x5ED1540
        public void GetData(){} // RVA: 0x5ED1570
        public void SetData(){} // RVA: 0x5ED16A0
        public void FreeData(){} // RVA: 0x5ED1830
        public void PopulateElement(){} // RVA: 0x5ED1890
    }

    public class LocalDataStoreElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xC5BE60
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x2DEE30
        public void get_Cookie(){} // RVA: 0x2E07C0
    }

    public class LocalDataStoreHolder
    {
        public object Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void Finalize(){} // RVA: 0x5ED13E0
        public void get_Store(){} // RVA: 0x2F8380
    }

    public class LocalDataStoreMgr
    {
        // ── Methods ──
        public void CreateLocalDataStore(){} // RVA: 0x5ED1E00
        public void DeleteLocalDataStore(){} // RVA: 0x5ED2170
        public void AllocateDataSlot(){} // RVA: 0x5ED22E0
        public void AllocateNamedDataSlot(){} // RVA: 0x5ED27C0
        public void GetNamedDataSlot(){} // RVA: 0x5ED29A0
        public void FreeNamedDataSlot(){} // RVA: 0x5ED2BB0
        public void FreeDataSlot(){} // RVA: 0x5ED2D20
        public void ValidateSlot(){} // RVA: 0x5ED2FA0
        public void GetSlotTableLength(){} // RVA: 0xF3F910
        public void .ctor(){} // RVA: 0x5ED3020
    }

    public class LocalDataStoreSlot
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5ED1D30
        public void get_Manager(){} // RVA: 0x2F8380
        public void get_Slot(){} // RVA: 0x5BED50
        public void get_Cookie(){} // RVA: 0x30B0C0
        public void Finalize(){} // RVA: 0x5ED1DA0
    }

}