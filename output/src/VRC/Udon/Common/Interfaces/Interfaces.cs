// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Common.Interfaces
// Classes: 26
// Methods: 153

namespace VRC.Udon.Common.Interfaces
{
    public class IUAssemblyAssembler
    {
        // ── Methods ──
        public void Assemble(){} // RVA: 0xCE10
    }

    public class IUAssemblyDisassembler
    {
        // ── Methods ──
        public void DisassembleProgram(){} // RVA: 0xCE10
        public void DisassembleInstruction(){} // RVA: 0x1E6A0
    }

    public class IUdonBehaviour
    {
        // ── Methods ──
        public void get_IsNetworkingSupported(){} // RVA: 0xDBE0
        public void InitializeUdonContent(){} // RVA: 0x24A50
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
        public void get_GetterType(){} // RVA: 0xCD60
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
        public void SendCustomEvent(){} // RVA: 0x24B10
        public void SendCustomNetworkEvent(){} // RVA: 0x27F90 | overloaded x9
        public void RequestSerialization(){} // RVA: 0x24A50
        public void SendCustomEventDelayedSeconds(){}
        public void SendCustomEventDelayedFrames(){}
        public void get_enabled(){} // RVA: 0xDBE0
        public void set_enabled(){} // RVA: 0x25130
        public void get_DisableInteractive(){} // RVA: 0xDBE0
        public void set_DisableInteractive(){} // RVA: 0x25130
        public void get_DisableEventProcessing(){} // RVA: 0xDBE0
        public void set_DisableEventProcessing(){} // RVA: 0x25130
        public void get_InteractionText(){} // RVA: 0xCD60
        public void set_InteractionText(){} // RVA: 0x24B10
        public void RunProgram(){} // RVA: 0x24B10
        public void RunEvent(){} // RVA: 0x11120 | overloaded x5
        public void RunInputEvent(){}
    }

    public class IUdonEventScheduler
    {
        // ── Methods ──
        public void ScheduleDelayedSecondsEvent(){}
        public void ScheduleDelayedFramesEvent(){}
        public void HasAnyPendingScheduledEvents(){} // RVA: 0xE1F0
        public void RunScheduledEvents(){} // RVA: 0x24FA0
        public void ClearScheduledEvents(){} // RVA: 0x24A50
        public void add_OnEventScheduled(){} // RVA: 0x24B10
        public void remove_OnEventScheduled(){} // RVA: 0x24B10
    }

    public class IUdonHeap
    {
        // ── Methods ──
        public void InitializeHeapVariable(){} // RVA: 0x24FA0 | overloaded x2
        public void IsHeapVariableInitialized(){} // RVA: 0xE1F0
        public void CopyHeapVariable(){}
        public void SetHeapVariable(){} // RVA: 0x283FA0 | overloaded x2
        public void GetHeapVariable(){} // RVA: 0x283FA0 | overloaded x2
        public void TryGetHeapVariable(){} // overloaded x2
        public void GetHeapVariableType(){}
        public void GetHeapCapacity(){} // RVA: 0xD840
        public void DumpHeapObjects(){} // RVA: 0x24B10
    }

    public class IUdonHeapFactory
    {
        // ── Methods ──
        public void ConstructUdonHeap(){} // RVA: 0xCD60 | overloaded x2
    }

    public class IUdonProgram
    {
        // ── Methods ──
        public void get_InstructionSetIdentifier(){} // RVA: 0xCD60
        public void get_InstructionSetVersion(){} // RVA: 0xD840
        public void get_ByteCode(){} // RVA: 0xCD60
        public void get_Heap(){} // RVA: 0xCD60
        public void get_EntryPoints(){} // RVA: 0xCD60
        public void get_SymbolTable(){} // RVA: 0xCD60
        public void get_SyncMetadataTable(){} // RVA: 0xCD60
        public void get_UpdateOrder(){} // RVA: 0xD840
    }

    public class IUdonProgramVariableAccessTarget
    {
        // ── Methods ──
        public void GetProgramVariableType(){} // RVA: 0xCE10
        public void GetProgramVariable(){} // RVA: 0xCE10 | overloaded x2
        public void TryGetProgramVariable(){} // RVA: 0x11120 | overloaded x2
        public void SetProgramVariable(){} // RVA: 0x2DC60 | overloaded x2
    }

    public class IUdonSecurityFilter
    {
        // ── Methods ──
        public void ApplyFilter(){} // RVA: 0x24B10
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x24B10
        public void get_LightReservedLayerMask(){} // RVA: 0xD840
        public void set_LightReservedLayerMask(){} // RVA: 0x24FA0
    }

    public class IUdonSecurityFilter`1 : ApplyFilter
    {
        // ── Methods ──
        public void ApplyFilter(){} // RVA: 0x24B10
    }

    public class IUdonSymbol
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0xCD60
        public void get_Type(){} // RVA: 0xCD60
        public void get_Address(){} // RVA: 0xD840
    }

    public class IUdonSymbolTable
    {
        // ── Methods ──
        public void HasAddressForSymbol(){} // RVA: 0xDE40
        public void HasSymbolForAddress(){} // RVA: 0xE1F0
        public void GetSymbolFromAddress(){}
        public void TryGetSymbolFromAddress(){}
        public void GetAddressFromSymbol(){} // RVA: 0x12590
        public void TryGetAddressFromSymbol(){} // RVA: 0x11120
        public void GetExportedSymbols(){}
        public void GetSymbols(){}
        public void HasExportedSymbol(){} // RVA: 0xDE40
        public void GetSymbolType(){} // RVA: 0xCE10
    }

    public class IUdonSyncMetadata
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0xCD60
        public void get_Properties(){} // RVA: 0xCD60
    }

    public class IUdonSyncMetadataTable
    {
        // ── Methods ──
        public void GetAllSyncMetadata(){} // RVA: 0xCD60
        public void GetSyncMetadataFromSymbol(){} // RVA: 0xCE10
    }

    public class IUdonSyncProperty
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0xCD60
        public void get_InterpolationAlgorithm(){} // RVA: 0xD840
    }

    public class IUdonSyncTarget
    {
        // ── Methods ──
        public void get_SyncMetadataTable(){} // RVA: 0xCD60
    }

    public class IUdonVM
    {
        // ── Methods ──
        public void LoadProgram(){} // RVA: 0xDE40
        public void RetrieveProgram(){} // RVA: 0xCD60
        public void SetProgramCounter(){} // RVA: 0x24FA0
        public void GetProgramCounter(){} // RVA: 0xD840
        public void Interpret(){} // RVA: 0xD840
        public void InspectHeap(){} // RVA: 0xCD60
        public void set_DebugLogging(){} // RVA: 0x25130
        public void get_DebugLogging(){} // RVA: 0xDBE0
    }

    public class IUdonVMFactory
    {
        // ── Methods ──
        public void ConstructUdonVM(){} // RVA: 0xCD60
    }

    public class IUdonVariable
    {
        // ── Methods ──
        public void get_SymbolName(){} // RVA: 0xCD60
        public void get_Value(){} // RVA: 0xCD60
        public void set_Value(){} // RVA: 0x24B10
        public void get_DeclaredType(){} // RVA: 0xCD60
    }

    public class IUdonVariableTable
    {
        // ── Methods ──
        public void get_VariableSymbols(){} // RVA: 0xCD60
        public void TrySetVariableValue(){} // RVA: 0x283FA0 | overloaded x2
        public void TryGetVariableValue(){} // RVA: 0x11120 | overloaded x2
        public void TryGetVariableType(){} // RVA: 0x11120
        public void TryAddVariable(){} // RVA: 0xDE40
        public void RemoveVariable(){} // RVA: 0xDE40
    }

    public class IUdonWrapper
    {
        // ── Methods ──
        public void GetExternFunctionParameterCount(){} // RVA: 0x12590
        public void GetExternFunctionDelegate(){} // RVA: 0xCE10
        public void RegisterWrapperModule(){} // RVA: 0x24B10
        public void GetWrapperModuleByName(){} // RVA: 0xCE10
    }

    public class IUdonWrapperFactory
    {
        // ── Methods ──
        public void GetWrapper(){} // RVA: 0xCD60
    }

    public class IUdonWrapperModule
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0xCD60
        public void GetExternFunctionParameterCount(){} // RVA: 0x12590
        public void GetExternFunctionDelegate(){} // RVA: 0xCE10
    }

}