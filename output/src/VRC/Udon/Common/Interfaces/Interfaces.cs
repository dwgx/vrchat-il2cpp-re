// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Common.Interfaces
// Classes: 26
// Methods: 153

namespace VRC.Udon.Common.Interfaces
{
    public class IUAssemblyAssembler
    {
        // ── Methods ──
        public void Assemble(){} // RVA: 0x7FFAC2C58F40
    }

    public class IUAssemblyDisassembler
    {
        // ── Methods ──
        public void DisassembleProgram(){} // RVA: 0x7FFAC2C58F40
        public void DisassembleInstruction(){} // RVA: 0x7FFAC2C6A6F0
    }

    public class IUdonBehaviour
    {
        public object IsNetworkingSupported;

        // ── Methods ──
        public void get_IsNetworkingSupported(){} // RVA: 0x7FFAC2C59D00
        public void InitializeUdonContent(){} // RVA: 0x7FFAC2C70980
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
        public void get_GetterType(){} // RVA: 0x7FFAC2C58E90
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
        public void SendCustomEvent(){} // RVA: 0x7FFAC2C70A40
        public void SendCustomNetworkEvent(){} // RVA: 0x7FFAC2C73F00 | overloaded x9
        public void RequestSerialization(){} // RVA: 0x7FFAC2C70980
        public void SendCustomEventDelayedSeconds(){}
        public void SendCustomEventDelayedFrames(){}
        public void get_enabled(){} // RVA: 0x7FFAC2C59D00
        public void set_enabled(){} // RVA: 0x7FFAC2C71060
        public void get_DisableInteractive(){} // RVA: 0x7FFAC2C59D00
        public void set_DisableInteractive(){} // RVA: 0x7FFAC2C71060
        public void get_DisableEventProcessing(){} // RVA: 0x7FFAC2C59D00
        public void set_DisableEventProcessing(){} // RVA: 0x7FFAC2C71060
        public void get_InteractionText(){} // RVA: 0x7FFAC2C58E90
        public void set_InteractionText(){} // RVA: 0x7FFAC2C70A40
        public void RunProgram(){} // RVA: 0x7FFAC2C70A40
        public void RunEvent(){} // RVA: 0x7FFAC2C5D200 | overloaded x5
        public void RunInputEvent(){}
    }

    public class IUdonEventScheduler
    {
        // ── Methods ──
        public void ScheduleDelayedSecondsEvent(){}
        public void ScheduleDelayedFramesEvent(){}
        public void HasAnyPendingScheduledEvents(){} // RVA: 0x7FFAC2C5A310
        public void RunScheduledEvents(){} // RVA: 0x7FFAC2C70ED0
        public void ClearScheduledEvents(){} // RVA: 0x7FFAC2C70980
        public void add_OnEventScheduled(){} // RVA: 0x7FFAC2C70A40
        public void remove_OnEventScheduled(){} // RVA: 0x7FFAC2C70A40
    }

    public class IUdonHeap
    {
        // ── Methods ──
        public void InitializeHeapVariable(){} // RVA: 0x7FFAC2C70ED0 | overloaded x2
        public void IsHeapVariableInitialized(){} // RVA: 0x7FFAC2C5A310
        public void CopyHeapVariable(){}
        public void SetHeapVariable(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetHeapVariable(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void TryGetHeapVariable(){} // overloaded x2
        public void GetHeapVariableType(){}
        public void GetHeapCapacity(){} // RVA: 0x7FFAC2C59960
        public void DumpHeapObjects(){} // RVA: 0x7FFAC2C70A40
    }

    public class IUdonHeapFactory
    {
        // ── Methods ──
        public void ConstructUdonHeap(){} // RVA: 0x7FFAC2C58E90 | overloaded x2
    }

    public class IUdonProgram
    {
        public object InstructionSetIdentifier;
        public object InstructionSetVersion;
        public object ByteCode;
        public object Heap;
        public object EntryPoints;
        public object SymbolTable;
        public object SyncMetadataTable;
        public object UpdateOrder;

        // ── Methods ──
        public void get_InstructionSetIdentifier(){} // RVA: 0x7FFAC2C58E90
        public void get_InstructionSetVersion(){} // RVA: 0x7FFAC2C59960
        public void get_ByteCode(){} // RVA: 0x7FFAC2C58E90
        public void get_Heap(){} // RVA: 0x7FFAC2C58E90
        public void get_EntryPoints(){} // RVA: 0x7FFAC2C58E90
        public void get_SymbolTable(){} // RVA: 0x7FFAC2C58E90
        public void get_SyncMetadataTable(){} // RVA: 0x7FFAC2C58E90
        public void get_UpdateOrder(){} // RVA: 0x7FFAC2C59960
    }

    public class IUdonProgramVariableAccessTarget
    {
        // ── Methods ──
        public void GetProgramVariableType(){} // RVA: 0x7FFAC2C58F40
        public void GetProgramVariable(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void TryGetProgramVariable(){} // RVA: 0x7FFAC2C5D200 | overloaded x2
        public void SetProgramVariable(){} // RVA: 0x7FFAC2C79B30 | overloaded x2
    }

    public class IUdonSecurityFilter
    {
        public object LightReservedLayerMask;

        // ── Methods ──
        public void ApplyFilter(){} // RVA: 0x7FFAC2C70A40
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7FFAC2C70A40
        public void get_LightReservedLayerMask(){} // RVA: 0x7FFAC2C59960
        public void set_LightReservedLayerMask(){} // RVA: 0x7FFAC2C70ED0
    }

    public class IUdonSecurityFilter`1
    {
        // ── Methods ──
        public void ApplyFilter(){} // RVA: 0x7FFAC2C70A40
    }

    public class IUdonSymbol
    {
        public object Name;
        public object Type;
        public object Address;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void get_Type(){} // RVA: 0x7FFAC2C58E90
        public void get_Address(){} // RVA: 0x7FFAC2C59960
    }

    public class IUdonSymbolTable
    {
        // ── Methods ──
        public void HasAddressForSymbol(){} // RVA: 0x7FFAC2C59F60
        public void HasSymbolForAddress(){} // RVA: 0x7FFAC2C5A310
        public void GetSymbolFromAddress(){}
        public void TryGetSymbolFromAddress(){}
        public void GetAddressFromSymbol(){} // RVA: 0x7FFAC2C5E6B0
        public void TryGetAddressFromSymbol(){} // RVA: 0x7FFAC2C5D200
        public void GetExportedSymbols(){}
        public void GetSymbols(){}
        public void HasExportedSymbol(){} // RVA: 0x7FFAC2C59F60
        public void GetSymbolType(){} // RVA: 0x7FFAC2C58F40
    }

    public class IUdonSyncMetadata
    {
        public object Name;
        public object Properties;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void get_Properties(){} // RVA: 0x7FFAC2C58E90
    }

    public class IUdonSyncMetadataTable
    {
        // ── Methods ──
        public void GetAllSyncMetadata(){} // RVA: 0x7FFAC2C58E90
        public void GetSyncMetadataFromSymbol(){} // RVA: 0x7FFAC2C58F40
    }

    public class IUdonSyncProperty
    {
        public object Name;
        public object InterpolationAlgorithm;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void get_InterpolationAlgorithm(){} // RVA: 0x7FFAC2C59960
    }

    public class IUdonSyncTarget
    {
        public object SyncMetadataTable;

        // ── Methods ──
        public void get_SyncMetadataTable(){} // RVA: 0x7FFAC2C58E90
    }

    public class IUdonVM
    {
        public object DebugLogging;

        // ── Methods ──
        public void LoadProgram(){} // RVA: 0x7FFAC2C59F60
        public void RetrieveProgram(){} // RVA: 0x7FFAC2C58E90
        public void SetProgramCounter(){} // RVA: 0x7FFAC2C70ED0
        public void GetProgramCounter(){} // RVA: 0x7FFAC2C59960
        public void Interpret(){} // RVA: 0x7FFAC2C59960
        public void InspectHeap(){} // RVA: 0x7FFAC2C58E90
        public void set_DebugLogging(){} // RVA: 0x7FFAC2C71060
        public void get_DebugLogging(){} // RVA: 0x7FFAC2C59D00
    }

    public class IUdonVMFactory
    {
        // ── Methods ──
        public void ConstructUdonVM(){} // RVA: 0x7FFAC2C58E90
    }

    public class IUdonVariable
    {
        public object SymbolName;
        public object Value;
        public object DeclaredType;

        // ── Methods ──
        public void get_SymbolName(){} // RVA: 0x7FFAC2C58E90
        public void get_Value(){} // RVA: 0x7FFAC2C58E90
        public void set_Value(){} // RVA: 0x7FFAC2C70A40
        public void get_DeclaredType(){} // RVA: 0x7FFAC2C58E90
    }

    public class IUdonVariableTable
    {
        public object VariableSymbols;

        // ── Methods ──
        public void get_VariableSymbols(){} // RVA: 0x7FFAC2C58E90
        public void TrySetVariableValue(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void TryGetVariableValue(){} // RVA: 0x7FFAC2C5D200 | overloaded x2
        public void TryGetVariableType(){} // RVA: 0x7FFAC2C5D200
        public void TryAddVariable(){} // RVA: 0x7FFAC2C59F60
        public void RemoveVariable(){} // RVA: 0x7FFAC2C59F60
    }

    public class IUdonWrapper
    {
        // ── Methods ──
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFAC2C5E6B0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFAC2C58F40
        public void RegisterWrapperModule(){} // RVA: 0x7FFAC2C70A40
        public void GetWrapperModuleByName(){} // RVA: 0x7FFAC2C58F40
    }

    public class IUdonWrapperFactory
    {
        // ── Methods ──
        public void GetWrapper(){} // RVA: 0x7FFAC2C58E90
    }

    public class IUdonWrapperModule
    {
        public object Name;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFAC2C5E6B0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFAC2C58F40
    }

}