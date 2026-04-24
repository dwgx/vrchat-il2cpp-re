// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Common.Interfaces
// Classes: 14
// Methods: 102

namespace VRC.Udon.Common.Interfaces
{
    public class IUdonBehaviour
    {
        public object IsNetworkingSupported;

        // ── Methods ──
        public void get_IsNetworkingSupported(){} // RVA: 0x7FFD4E079D00
        public void InitializeUdonContent(){} // RVA: 0x7FFD4E090980
    }

    public class IUdonComponentGetter
    {
        // ── Methods ──
        public void GetComponent__T(){}
        public void GetComponentInChildren__T(){}
        public void GetComponentInChildren__SystemBoolean__T(){}
        public void GetComponentInParent__T(){}
        public void GetComponentInParent__SystemBoolean__T(){}
        public void GetComponents__TArray(){}
        public void GetComponents__ListT__SystemVoid(){}
        public void GetComponentsInChildren__SystemBoolean__TArray(){}
        public void GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){}
        public void GetComponentsInChildren__TArray(){}
        public void GetComponentsInChildren__ListT__SystemVoid(){}
        public void GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){}
        public void GetComponentsInParent__SystemBoolean__TArray(){}
        public void GetComponentsInParent__TArray(){}
    }

    public class IUdonComponentGetterModule
    {
        public object GetterType;

        // ── Methods ──
        public void get_GetterType(){} // RVA: 0x7FFD4E078E90
        public void GetComponent__T(){}
        public void GetComponentInChildren__T(){}
        public void GetComponentInChildren__SystemBoolean__T(){}
        public void GetComponentInParent__T(){}
        public void GetComponentInParent__SystemBoolean__T(){}
        public void GetComponents__TArray(){}
        public void GetComponents__ListT__SystemVoid(){}
        public void GetComponentsInChildren__SystemBoolean__TArray(){}
        public void GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){}
        public void GetComponentsInChildren__TArray(){}
        public void GetComponentsInChildren__ListT__SystemVoid(){}
        public void GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){}
        public void GetComponentsInParent__SystemBoolean__TArray(){}
        public void GetComponentsInParent__TArray(){}
    }

    public class IUdonEventReceiver
    {
        public object enabled;
        public object DisableInteractive;
        public object DisableEventProcessing;
        public object InteractionText;

        // ── Methods ──
        public void SendCustomEvent(){} // RVA: 0x7FFD4E090A40
        public void SendCustomNetworkEvent(){} // RVA: 0x7FFD4E093F00 | overloaded x9
        public void RequestSerialization(){} // RVA: 0x7FFD4E090980
        public void SendCustomEventDelayedSeconds(){}
        public void SendCustomEventDelayedFrames(){}
        public void get_enabled(){} // RVA: 0x7FFD4E079D00
        public void set_enabled(){} // RVA: 0x7FFD4E091060
        public void get_DisableInteractive(){} // RVA: 0x7FFD4E079D00
        public void set_DisableInteractive(){} // RVA: 0x7FFD4E091060
        public void get_DisableEventProcessing(){} // RVA: 0x7FFD4E079D00
        public void set_DisableEventProcessing(){} // RVA: 0x7FFD4E091060
        public void get_InteractionText(){} // RVA: 0x7FFD4E078E90
        public void set_InteractionText(){} // RVA: 0x7FFD4E090A40
        public void RunProgram(){} // RVA: 0x7FFD4E090A40
        public void RunEvent(){} // RVA: 0x7FFD4E07D200 | overloaded x5
        public void RunInputEvent(){}
    }

    public class IUdonHeap
    {
        // ── Methods ──
        public void InitializeHeapVariable(){} // RVA: 0x7FFD4E090ED0 | overloaded x2
        public void IsHeapVariableInitialized(){} // RVA: 0x7FFD4E07A310
        public void CopyHeapVariable(){}
        public void SetHeapVariable(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetHeapVariable(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void TryGetHeapVariable(){} // overloaded x2
        public void GetHeapVariableType(){}
        public void GetHeapCapacity(){} // RVA: 0x7FFD4E079960
        public void DumpHeapObjects(){} // RVA: 0x7FFD4E090A40
    }

    public class IUdonProgramVariableAccessTarget
    {
        // ── Methods ──
        public void GetProgramVariableType(){} // RVA: 0x7FFD4E078F40
        public void GetProgramVariable(){} // RVA: 0x7FFD4E078F40 | overloaded x2
        public void TryGetProgramVariable(){} // RVA: 0x7FFD4E07D200 | overloaded x2
        public void SetProgramVariable(){} // RVA: 0x7FFD4E099B30 | overloaded x2
    }

    public class IUdonSecurityFilter
    {
        public object LightReservedLayerMask;

        // ── Methods ──
        public void ApplyFilter(){} // RVA: 0x7FFD4E090A40
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7FFD4E090A40
        public void get_LightReservedLayerMask(){} // RVA: 0x7FFD4E079960
        public void set_LightReservedLayerMask(){} // RVA: 0x7FFD4E090ED0
    }

    public class IUdonSecurityFilter`1
    {
        // ── Methods ──
        public void ApplyFilter(){} // RVA: 0x7FFD4E090A40
    }

    public class IUdonSyncTarget
    {
        public object SyncMetadataTable;

        // ── Methods ──
        public void get_SyncMetadataTable(){} // RVA: 0x7FFD4E078E90
    }

    public class IUdonVMFactory
    {
        // ── Methods ──
        public void ConstructUdonVM(){} // RVA: 0x7FFD4E078E90
    }

    public class IUdonVariableTable
    {
        public object VariableSymbols;

        // ── Methods ──
        public void get_VariableSymbols(){} // RVA: 0x7FFD4E078E90
        public void TrySetVariableValue(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void TryGetVariableValue(){} // RVA: 0x7FFD4E07D200 | overloaded x2
        public void TryGetVariableType(){} // RVA: 0x7FFD4E07D200
        public void TryAddVariable(){} // RVA: 0x7FFD4E079F60
        public void RemoveVariable(){} // RVA: 0x7FFD4E079F60
    }

    public class IUdonWrapper
    {
        // ── Methods ──
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD4E07E6B0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD4E078F40
        public void RegisterWrapperModule(){} // RVA: 0x7FFD4E090A40
        public void GetWrapperModuleByName(){} // RVA: 0x7FFD4E078F40
    }

    public class IUdonWrapperFactory
    {
        // ── Methods ──
        public void GetWrapper(){} // RVA: 0x7FFD4E078E90
    }

    public class IUdonWrapperModule
    {
        public object Name;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD4E078E90
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD4E07E6B0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD4E078F40
    }

}