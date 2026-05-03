// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Common.Interfaces
// Classes: 26
// Methods: 153

namespace VRC.Udon.Common.Interfaces
{
    public class IUAssemblyAssembler
    {
        // ── Methods ──
        public void Assemble(){} // RVA: 0x7FFE80E2E390
    }

    public class IUAssemblyDisassembler
    {
        // ── Methods ──
        public void DisassembleProgram(){} // RVA: 0x7FFE80E2E390
        public void DisassembleInstruction(){} // RVA: 0x7FFE80E3FC10
    }

    public class IUdonBehaviour
    {
        // ── Methods ──
        public void get_IsNetworkingSupported(){} // RVA: 0x7FFE80E2F150
        public void InitializeUdonContent(){} // RVA: 0x7FFE80E45FE0
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
        // ── Methods ──
        public void get_GetterType(){} // RVA: 0x7FFE80E2E2E0
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
        // ── Methods ──
        public void SendCustomEvent(){} // RVA: 0x7FFE80E460A0
        public void SendCustomNetworkEvent(){} // RVA: 0x7FFE80E49570 | overloaded x9
        public void RequestSerialization(){} // RVA: 0x7FFE80E45FE0
        public void SendCustomEventDelayedSeconds(){}
        public void SendCustomEventDelayedFrames(){}
        public void get_enabled(){} // RVA: 0x7FFE80E2F150
        public void set_enabled(){} // RVA: 0x7FFE80E466C0
        public void get_DisableInteractive(){} // RVA: 0x7FFE80E2F150
        public void set_DisableInteractive(){} // RVA: 0x7FFE80E466C0
        public void get_DisableEventProcessing(){} // RVA: 0x7FFE80E2F150
        public void set_DisableEventProcessing(){} // RVA: 0x7FFE80E466C0
        public void get_InteractionText(){} // RVA: 0x7FFE80E2E2E0
        public void set_InteractionText(){} // RVA: 0x7FFE80E460A0
        public void RunProgram(){} // RVA: 0x7FFE80E460A0
        public void RunEvent(){} // RVA: 0x7FFE80E32650 | overloaded x5
        public void RunInputEvent(){}
    }

    public class IUdonEventScheduler
    {
        // ── Methods ──
        public void ScheduleDelayedSecondsEvent(){}
        public void ScheduleDelayedFramesEvent(){}
        public void HasAnyPendingScheduledEvents(){} // RVA: 0x7FFE80E2F760
        public void RunScheduledEvents(){} // RVA: 0x7FFE80E46530
        public void ClearScheduledEvents(){} // RVA: 0x7FFE80E45FE0
        public void add_OnEventScheduled(){} // RVA: 0x7FFE80E460A0
        public void remove_OnEventScheduled(){} // RVA: 0x7FFE80E460A0
    }

    public class IUdonHeap
    {
        // ── Methods ──
        public void InitializeHeapVariable(){} // RVA: 0x7FFE80E46530 | overloaded x2
        public void IsHeapVariableInitialized(){} // RVA: 0x7FFE80E2F760
        public void CopyHeapVariable(){}
        public void SetHeapVariable(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetHeapVariable(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void TryGetHeapVariable(){} // overloaded x2
        public void GetHeapVariableType(){}
        public void GetHeapCapacity(){} // RVA: 0x7FFE80E2EDB0
        public void DumpHeapObjects(){} // RVA: 0x7FFE80E460A0
    }

    public class IUdonHeapFactory
    {
        // ── Methods ──
        public void ConstructUdonHeap(){} // RVA: 0x7FFE80E2E2E0 | overloaded x2
    }

    public class IUdonProgram
    {
        // ── Methods ──
        public void get_InstructionSetIdentifier(){} // RVA: 0x7FFE80E2E2E0
        public void get_InstructionSetVersion(){} // RVA: 0x7FFE80E2EDB0
        public void get_ByteCode(){} // RVA: 0x7FFE80E2E2E0
        public void get_Heap(){} // RVA: 0x7FFE80E2E2E0
        public void get_EntryPoints(){} // RVA: 0x7FFE80E2E2E0
        public void get_SymbolTable(){} // RVA: 0x7FFE80E2E2E0
        public void get_SyncMetadataTable(){} // RVA: 0x7FFE80E2E2E0
        public void get_UpdateOrder(){} // RVA: 0x7FFE80E2EDB0
    }

    public class IUdonProgramVariableAccessTarget
    {
        // ── Methods ──
        public void GetProgramVariableType(){} // RVA: 0x7FFE80E2E390
        public void GetProgramVariable(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void TryGetProgramVariable(){} // RVA: 0x7FFE80E32650 | overloaded x2
        public void SetProgramVariable(){} // RVA: 0x7FFE80E4F230 | overloaded x2
    }

    public class IUdonSecurityFilter
    {
        // ── Methods ──
        public void ApplyFilter(){} // RVA: 0x7FFE80E460A0
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7FFE80E460A0
        public void get_LightReservedLayerMask(){} // RVA: 0x7FFE80E2EDB0
        public void set_LightReservedLayerMask(){} // RVA: 0x7FFE80E46530
    }

    public class IUdonSecurityFilter`1
    {
        // ── Methods ──
        public void ApplyFilter(){} // RVA: 0x7FFE80E460A0
    }

    public class IUdonSymbol
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
        public void get_Type(){} // RVA: 0x7FFE80E2E2E0
        public void get_Address(){} // RVA: 0x7FFE80E2EDB0
    }

    public class IUdonSymbolTable
    {
        // ── Methods ──
        public void HasAddressForSymbol(){} // RVA: 0x7FFE80E2F3B0
        public void HasSymbolForAddress(){} // RVA: 0x7FFE80E2F760
        public void GetSymbolFromAddress(){}
        public void TryGetSymbolFromAddress(){}
        public void GetAddressFromSymbol(){} // RVA: 0x7FFE80E33B00
        public void TryGetAddressFromSymbol(){} // RVA: 0x7FFE80E32650
        public void GetExportedSymbols(){}
        public void GetSymbols(){}
        public void HasExportedSymbol(){} // RVA: 0x7FFE80E2F3B0
        public void GetSymbolType(){} // RVA: 0x7FFE80E2E390
    }

    public class IUdonSyncMetadata
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
        public void get_Properties(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IUdonSyncMetadataTable
    {
        // ── Methods ──
        public void GetAllSyncMetadata(){} // RVA: 0x7FFE80E2E2E0
        public void GetSyncMetadataFromSymbol(){} // RVA: 0x7FFE80E2E390
    }

    public class IUdonSyncProperty
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
        public void get_InterpolationAlgorithm(){} // RVA: 0x7FFE80E2EDB0
    }

    public class IUdonSyncTarget
    {
        // ── Methods ──
        public void get_SyncMetadataTable(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IUdonVM
    {
        // ── Methods ──
        public void LoadProgram(){} // RVA: 0x7FFE80E2F3B0
        public void RetrieveProgram(){} // RVA: 0x7FFE80E2E2E0
        public void SetProgramCounter(){} // RVA: 0x7FFE80E46530
        public void GetProgramCounter(){} // RVA: 0x7FFE80E2EDB0
        public void Interpret(){} // RVA: 0x7FFE80E2EDB0
        public void InspectHeap(){} // RVA: 0x7FFE80E2E2E0
        public void set_DebugLogging(){} // RVA: 0x7FFE80E466C0
        public void get_DebugLogging(){} // RVA: 0x7FFE80E2F150
    }

    public class IUdonVMFactory
    {
        // ── Methods ──
        public void ConstructUdonVM(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IUdonVariable
    {
        // ── Methods ──
        public void get_SymbolName(){} // RVA: 0x7FFE80E2E2E0
        public void get_Value(){} // RVA: 0x7FFE80E2E2E0
        public void set_Value(){} // RVA: 0x7FFE80E460A0
        public void get_DeclaredType(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IUdonVariableTable
    {
        // ── Methods ──
        public void get_VariableSymbols(){} // RVA: 0x7FFE80E2E2E0
        public void TrySetVariableValue(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void TryGetVariableValue(){} // RVA: 0x7FFE80E32650 | overloaded x2
        public void TryGetVariableType(){} // RVA: 0x7FFE80E32650
        public void TryAddVariable(){} // RVA: 0x7FFE80E2F3B0
        public void RemoveVariable(){} // RVA: 0x7FFE80E2F3B0
    }

    public class IUdonWrapper
    {
        // ── Methods ──
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFE80E33B00
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFE80E2E390
        public void RegisterWrapperModule(){} // RVA: 0x7FFE80E460A0
        public void GetWrapperModuleByName(){} // RVA: 0x7FFE80E2E390
    }

    public class IUdonWrapperFactory
    {
        // ── Methods ──
        public void GetWrapper(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IUdonWrapperModule
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFE80E33B00
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFE80E2E390
    }

}