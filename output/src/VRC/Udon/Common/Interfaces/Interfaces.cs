// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Common.Interfaces
// Classes: 28
// Methods: 147

namespace VRC.Udon.Common.Interfaces
{
    public class IUAssemblyAssembler
    {
        // ── Methods ──
        public void Assemble(){} // RVA: 0x87C540
    }

    public class IUAssemblyDisassembler
    {
        // ── Methods ──
        public void DisassembleProgram(){} // RVA: 0x87C540
        public void DisassembleInstruction(){} // RVA: 0x87C5F0
    }

    public class IUdonBehaviour
    {
        // ── Methods ──
        public void get_IsNetworkingSupported(){} // RVA: 0x87D280
        public void InitializeUdonContent(){} // RVA: 0x894290
    }

    public class IUdonBehaviour[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class IUdonComponentGetter
    {
        // ── Methods ──
        public void GetComponent__T(){} // RVA: 0x8943B0
        public void GetComponentInChildren__T(){} // RVA: 0x8943B0
        public void GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x8943B0
        public void GetComponentInParent__T(){} // RVA: 0x8943B0
        public void GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8943B0
        public void GetComponents__TArray(){} // RVA: 0x8943B0
        public void GetComponents__ListT__SystemVoid(){} // RVA: 0x8943B0
        public void GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8943B0
        public void GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8943B0
        public void GetComponentsInChildren__TArray(){} // RVA: 0x8943B0
        public void GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8943B0
        public void GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8943B0
        public void GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8943B0
        public void GetComponentsInParent__TArray(){} // RVA: 0x8943B0
    }

    public class IUdonComponentGetterModule
    {
        // ── Methods ──
        public void get_GetterType(){} // RVA: 0x87C0A0
        public void GetComponent__T(){} // RVA: 0x8943B0
        public void GetComponentInChildren__T(){} // RVA: 0x8943B0
        public void GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x8943B0
        public void GetComponentInParent__T(){} // RVA: 0x8943B0
        public void GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8943B0
        public void GetComponents__TArray(){} // RVA: 0x8943B0
        public void GetComponents__ListT__SystemVoid(){} // RVA: 0x8943B0
        public void GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8943B0
        public void GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8943B0
        public void GetComponentsInChildren__TArray(){} // RVA: 0x8943B0
        public void GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8943B0
        public void GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8943B0
        public void GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8943B0
        public void GetComponentsInParent__TArray(){} // RVA: 0x8943B0
    }

    public class IUdonEventReceiver
    {
        // ── Methods ──
        public void SendCustomEvent(){} // RVA: 0x894320
        public void SendCustomNetworkEvent(){} // RVA: 0x897D20
        public void RequestSerialization(){} // RVA: 0x894290
        public void SendCustomEventDelayedSeconds(){} // RVA: 0x8A14B0
        public void SendCustomEventDelayedFrames(){} // RVA: 0x89B9B0
        public void get_enabled(){} // RVA: 0x87D280
        public void set_enabled(){} // RVA: 0x894750
        public void get_DisableInteractive(){} // RVA: 0x87D280
        public void set_DisableInteractive(){} // RVA: 0x894750
        public void get_DisableEventProcessing(){} // RVA: 0x87D280
        public void set_DisableEventProcessing(){} // RVA: 0x894750
        public void get_InteractionText(){} // RVA: 0x87C0A0
        public void set_InteractionText(){} // RVA: 0x894320
        public void RunProgram(){} // RVA: 0x894320
        public void RunEvent(){} // RVA: 0x87D3C0
        public void RunInputEvent(){} // RVA: 0x8943B0
    }

    public class IUdonEventScheduler
    {
        // ── Methods ──
        public void ScheduleDelayedSecondsEvent(){} // RVA: 0x8A0EE0
        public void ScheduleDelayedFramesEvent(){} // RVA: 0x89DE00
        public void HasAnyPendingScheduledEvents(){} // RVA: 0x87DD20
        public void RunScheduledEvents(){} // RVA: 0x8944F0
        public void ClearScheduledEvents(){} // RVA: 0x894290
        public void add_OnEventScheduled(){} // RVA: 0x894320
        public void remove_OnEventScheduled(){} // RVA: 0x894320
    }

    public class IUdonHeap
    {
        // ── Methods ──
        public void InitializeHeapVariable(){} // RVA: 0x8944F0
        public void IsHeapVariableInitialized(){} // RVA: 0x87DD20
        public void CopyHeapVariable(){} // RVA: 0x8965E0
        public void SetHeapVariable(){} // RVA: 0xA94080
        public void GetHeapVariable(){} // RVA: 0xA94080
        public void TryGetHeapVariable(){} // RVA: 0x87E350
        public void GetHeapVariableType(){} // RVA: 0x87C160
        public void GetHeapCapacity(){} // RVA: 0x87C130
        public void DumpHeapObjects(){} // RVA: 0x894320
    }

    public class IUdonHeapFactory
    {
        // ── Methods ──
        public void ConstructUdonHeap(){} // RVA: 0x87C160
    }

    public class IUdonProgram
    {
        // ── Methods ──
        public void get_InstructionSetIdentifier(){} // RVA: 0x87C0A0
        public void get_InstructionSetVersion(){} // RVA: 0x87C130
        public void get_ByteCode(){} // RVA: 0x87C0A0
        public void get_Heap(){} // RVA: 0x87C0A0
        public void get_EntryPoints(){} // RVA: 0x87C0A0
        public void get_SymbolTable(){} // RVA: 0x87C0A0
        public void get_SyncMetadataTable(){} // RVA: 0x87C0A0
        public void get_UpdateOrder(){} // RVA: 0x87C130
    }

    public class IUdonProgramVariableAccessTarget
    {
        // ── Methods ──
        public void GetProgramVariableType(){} // RVA: 0x87C540
        public void GetProgramVariable(){} // RVA: 0x87C540
        public void TryGetProgramVariable(){} // RVA: 0x87D3C0
        public void SetProgramVariable(){} // RVA: 0x8943B0
    }

    public class IUdonSecurityFilter
    {
        // ── Methods ──
        public void ApplyFilter(){} // RVA: 0x894320
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x894320
        public void get_LightReservedLayerMask(){} // RVA: 0x87C130
        public void set_LightReservedLayerMask(){} // RVA: 0x8944F0
    }

    public class IUdonSecurityFilter`1
    {
        // ── Methods ──
        public void ApplyFilter(){} // RVA: 0x894320
    }

    public class IUdonSecurityFilter`1
    {
        // ── Methods ──
        public void ApplyFilter(){} // RVA: 0x894320
    }

    public class IUdonSymbol
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x87C0A0
        public void get_Type(){} // RVA: 0x87C0A0
        public void get_Address(){} // RVA: 0x87C130
    }

    public class IUdonSymbolTable
    {
        // ── Methods ──
        public void HasAddressForSymbol(){} // RVA: 0x87D350
        public void HasSymbolForAddress(){} // RVA: 0x87DD20
        public void GetSymbolFromAddress(){} // RVA: 0x87C160
        public void TryGetSymbolFromAddress(){} // RVA: 0x87E350
        public void GetAddressFromSymbol(){} // RVA: 0x87D050
        public void TryGetAddressFromSymbol(){} // RVA: 0x87D3C0
        public void GetExportedSymbols(){} // RVA: 0x87C0A0
        public void GetSymbols(){} // RVA: 0x87C0A0
        public void HasExportedSymbol(){} // RVA: 0x87D350
        public void GetSymbolType(){} // RVA: 0x87C540
    }

    public class IUdonSyncMetadata
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x87C0A0
        public void get_Properties(){} // RVA: 0x87C0A0
    }

    public class IUdonSyncMetadataTable
    {
        // ── Methods ──
        public void GetAllSyncMetadata(){} // RVA: 0x87C0A0
        public void GetSyncMetadataFromSymbol(){} // RVA: 0x87C540
    }

    public class IUdonSyncProperty
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x87C0A0
        public void get_InterpolationAlgorithm(){} // RVA: 0x87C130
    }

    public class IUdonSyncTarget
    {
        // ── Methods ──
        public void get_SyncMetadataTable(){} // RVA: 0x87C0A0
    }

    public class IUdonVM
    {
        // ── Methods ──
        public void LoadProgram(){} // RVA: 0x87D350
        public void RetrieveProgram(){} // RVA: 0x87C0A0
        public void SetProgramCounter(){} // RVA: 0x8944F0
        public void GetProgramCounter(){} // RVA: 0x87C130
        public void Interpret(){} // RVA: 0x87C130
        public void InspectHeap(){} // RVA: 0x87C0A0
        public void set_DebugLogging(){} // RVA: 0x894750
        public void get_DebugLogging(){} // RVA: 0x87D280
    }

    public class IUdonVMFactory
    {
        // ── Methods ──
        public void ConstructUdonVM(){} // RVA: 0x87C0A0
    }

    public class IUdonVariable
    {
        // ── Methods ──
        public void get_SymbolName(){} // RVA: 0x87C0A0
        public void get_Value(){} // RVA: 0x87C0A0
        public void set_Value(){} // RVA: 0x894320
        public void get_DeclaredType(){} // RVA: 0x87C0A0
    }

    public class IUdonVariableTable
    {
        // ── Methods ──
        public void get_VariableSymbols(){} // RVA: 0x87C0A0
        public void TrySetVariableValue(){} // RVA: 0xA94080
        public void TryGetVariableValue(){} // RVA: 0x87D3C0
        public void TryGetVariableType(){} // RVA: 0x87D3C0
        public void TryAddVariable(){} // RVA: 0x87D350
        public void RemoveVariable(){} // RVA: 0x87D350
    }

    public class IUdonWrapper
    {
        // ── Methods ──
        public void GetExternFunctionParameterCount(){} // RVA: 0x87D050
        public void GetExternFunctionDelegate(){} // RVA: 0x87C540
        public void RegisterWrapperModule(){} // RVA: 0x894320
        public void GetWrapperModuleByName(){} // RVA: 0x87C540
    }

    public class IUdonWrapperFactory
    {
        // ── Methods ──
        public void GetWrapper(){} // RVA: 0x87C0A0
    }

    public class IUdonWrapperModule
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x87C0A0
        public void GetExternFunctionParameterCount(){} // RVA: 0x87D050
        public void GetExternFunctionDelegate(){} // RVA: 0x87C540
    }

}