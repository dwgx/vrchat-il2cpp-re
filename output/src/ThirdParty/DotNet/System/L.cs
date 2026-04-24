// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 5
// Methods: 47

namespace ThirdParty.DotNet.System
{
    public class LazyHelper : Object
    {
        public ityException State;
        public ityException NoneViaFactory; // 0x8
        public ityException PublicationOnlyViaConstructor; // 0x10
        public ityException PublicationOnlyViaFactory; // 0x18
        public ityException PublicationOnlyWaitForOtherThreadToPublish; // 0x20
        public Flags <State>k__BackingField; // 0x10
        public .Messaging.IInternalMessage.TargetIdentity.eDictionary _exceptionDispatch; // 0x18

        // ── Methods ──
        public void get_State(){} // RVA: 0x7FFD4E38E5C0
        public void .ctor(){} // RVA: 0x7FFD53A52A70 | overloaded x2
        public void ThrowException(){} // RVA: 0x7FFD53A52BB0
        public void Create(){} // RVA: 0x7FFD53A52BD0
        public void CreateViaDefaultConstructor(){} // RVA: 0x7FFD53A52D70
        public void GetModeFromIsThreadSafe(){} // RVA: 0x7FFD53A52DE0
        public void .cctor(){} // RVA: 0x7FFD53A52DF0
    }

    public class Lazy`1 : Object
    {
        public ityException IsValueCreated; // 0x10
        public ormation<ÏÎÏÍÍÌÏÍÌÌÍÍÌÎÎÎÌÎÌÍÎÌÍ.esolutionInternal> Value; // 0x18
        public ÏÎÏÍÍÌÏÍÌÌÍÍÌÎÎÎÌÎÌÍÎÌÍ.esolutionInternal _value; // 0x20

        // ── Methods ──
        public void CreateViaDefaultConstructor(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E097970 | overloaded x6
        public void ViaConstructor(){} // RVA: 0x7FFD4E090980
        public void ViaFactory(){} // RVA: 0x7FFD4E090ED0
        public void ExecutionAndPublication(){} // RVA: 0x7FFD4E096500
        public void PublicationOnly(){} // RVA: 0x7FFD4E2ADC40
        public void PublicationOnlyViaConstructor(){} // RVA: 0x7FFD4E090A40
        public void PublicationOnlyViaFactory(){} // RVA: 0x7FFD4E090A40
        public void PublicationOnlyWaitForOtherThreadToPublish(){} // RVA: 0x7FFD4E090980
        public void CreateValue(){} // RVA: 0x7FFD4E2ADC40
        public void ToString(){} // RVA: 0x7FFD4E078E90
        public void get_IsValueCreated(){} // RVA: 0x7FFD4E079D00
        public void get_Value(){} // RVA: 0x7FFD4E2ADC40
    }

    public class LocalDataStore : Object
    {
        public hEnd[] m_DataTable; // 0x10
        public D_MNd m_Manager; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53A88AF0
        public void Dispose(){} // RVA: 0x7FFD53A88BF0
        public void GetData(){} // RVA: 0x7FFD53A88C20
        public void SetData(){} // RVA: 0x7FFD53A88D50
        public void FreeData(){} // RVA: 0x7FFD53A88EE0
        public void PopulateElement(){} // RVA: 0x7FFD53A88F40
    }

    public class LocalDataStoreMgr : Object
    {
        public int InitialSlotTableSize;
        public int SlotTableDoubleThreshold;
        public int LargeSlotTableSizeIncrease;
        public bool[] m_SlotInfoTable; // 0x10
        public int m_FirstAvailableSlot; // 0x18
        public URA.woDigitYearMax<umTimesuff> m_ManagedLocalDataStores; // 0x20
        public URA.DateTime<string,TM> m_KeyToSlotMap; // 0x28
        public long m_CookieGenerator; // 0x30

        // ── Methods ──
        public void CreateLocalDataStore(){} // RVA: 0x7FFD53A894B0
        public void DeleteLocalDataStore(){} // RVA: 0x7FFD53A89820
        public void AllocateDataSlot(){} // RVA: 0x7FFD53A89990
        public void AllocateNamedDataSlot(){} // RVA: 0x7FFD53A89E70
        public void GetNamedDataSlot(){} // RVA: 0x7FFD53A8A050
        public void FreeNamedDataSlot(){} // RVA: 0x7FFD53A8A260
        public void FreeDataSlot(){} // RVA: 0x7FFD53A8A3D0
        public void ValidateSlot(){} // RVA: 0x7FFD53A8A650
        public void GetSlotTableLength(){} // RVA: 0x7FFD4E930620
        public void .ctor(){} // RVA: 0x7FFD53A8A6D0
    }

    public class LocalDataStoreSlot : Object
    {
        public D_MNd Manager; // 0x10
        public int Slot; // 0x18
        public long Cookie; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53A893E0
        public void get_Manager(){} // RVA: 0x7FFD4E35C380
        public void get_Slot(){} // RVA: 0x7FFD4E577800
        public void get_Cookie(){} // RVA: 0x7FFD4E36F0C0
        public void Finalize(){} // RVA: 0x7FFD53A89450
    }

}