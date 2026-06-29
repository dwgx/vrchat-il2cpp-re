// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Common.Interfaces
// Classes: 31
// Methods: 192

namespace VRC.Udon.Common.Interfaces
{
    public class IUAssemblyAssembler
    {
        // ── Methods ──
        public void Assemble(){} // RVA: 0x7A7E00B20
    }

    public class IUAssemblyDisassembler
    {
        // ── Methods ──
        public void DisassembleProgram(){} // RVA: 0x7A7E00B20
        public void DisassembleInstruction(){} // RVA: 0x7A7E00BD0
    }

    public class IUdonBehaviour
    {
        // ── Methods ──
        public void get_IsNetworkingSupported(){} // RVA: 0x7A7E01900
        public void InitializeUdonContent(){} // RVA: 0x7A7E18770
    }

    public class IUdonBehaviour[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class IUdonComponentGetter
    {
        // ── Methods ──
        public void GetComponent__T(){} // RVA: 0x7A7E18890
        public void GetComponentInChildren__T(){} // RVA: 0x7A7E18890
        public void GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7A7E18890
        public void GetComponentInParent__T(){} // RVA: 0x7A7E18890
        public void GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7A7E18890
        public void GetComponents__TArray(){} // RVA: 0x7A7E18890
        public void GetComponents__ListT__SystemVoid(){} // RVA: 0x7A7E18890
        public void GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7A7E18890
        public void GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7A7E18890
        public void GetComponentsInChildren__TArray(){} // RVA: 0x7A7E18890
        public void GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7A7E18890
        public void GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7A7E18890
        public void GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7A7E18890
        public void GetComponentsInParent__TArray(){} // RVA: 0x7A7E18890
    }

    public class IUdonComponentGetterModule
    {
        // ── Methods ──
        public void get_GetterType(){} // RVA: 0x7A7E00680
        public void GetComponent__T(){} // RVA: 0x7A7E18890
        public void GetComponentInChildren__T(){} // RVA: 0x7A7E18890
        public void GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7A7E18890
        public void GetComponentInParent__T(){} // RVA: 0x7A7E18890
        public void GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7A7E18890
        public void GetComponents__TArray(){} // RVA: 0x7A7E18890
        public void GetComponents__ListT__SystemVoid(){} // RVA: 0x7A7E18890
        public void GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7A7E18890
        public void GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7A7E18890
        public void GetComponentsInChildren__TArray(){} // RVA: 0x7A7E18890
        public void GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7A7E18890
        public void GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7A7E18890
        public void GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7A7E18890
        public void GetComponentsInParent__TArray(){} // RVA: 0x7A7E18890
    }

    public class IUdonEventReceiver
    {
        // ── Methods ──
        public void SendCustomEvent(){} // RVA: 0x7A7E18800
        public void SendCustomNetworkEvent(){} // RVA: 0x7A7E1C0E0
        public void RequestSerialization(){} // RVA: 0x7A7E18770
        public void SendCustomEventDelayedSeconds(){} // RVA: 0x7A7E25670
        public void SendCustomEventDelayedFrames(){} // RVA: 0x7A7E1E220
        public void get_enabled(){} // RVA: 0x7A7E01900
        public void set_enabled(){} // RVA: 0x7A7E18C30
        public void get_DisableInteractive(){} // RVA: 0x7A7E01900
        public void set_DisableInteractive(){} // RVA: 0x7A7E18C30
        public void get_DisableEventProcessing(){} // RVA: 0x7A7E01900
        public void set_DisableEventProcessing(){} // RVA: 0x7A7E18C30
        public void get_InteractionText(){} // RVA: 0x7A7E00680
        public void set_InteractionText(){} // RVA: 0x7A7E18800
        public void RunProgram(){} // RVA: 0x7A7E18800
        public void RunEvent(){} // RVA: 0x7A7E01A40
        public void RunInputEvent(){} // RVA: 0x7A7E18890
    }

    public class IUdonEventScheduler
    {
        // ── Methods ──
        public void ScheduleDelayedSecondsEvent(){} // RVA: 0x7A7E25260
        public void ScheduleDelayedFramesEvent(){} // RVA: 0x7A7E220D0
        public void HasAnyPendingScheduledEvents(){} // RVA: 0x7A7E01F00
        public void RunScheduledEvents(){} // RVA: 0x7A7E189D0
        public void ClearScheduledEvents(){} // RVA: 0x7A7E18770
        public void add_OnEventScheduled(){} // RVA: 0x7A7E18800
        public void remove_OnEventScheduled(){} // RVA: 0x7A7E18800
    }

    public class IUdonHeap
    {
        // ── Methods ──
        public void InitializeHeapVariable(){} // RVA: 0x7A7E189D0
        public void IsHeapVariableInitialized(){} // RVA: 0x7A7E01F00
        public void CopyHeapVariable(){} // RVA: 0x7A7E1ABE0
        public void SetHeapVariable(){} // RVA: 0x7A8051B10
        public void GetHeapVariable(){} // RVA: 0x7A8051B10
        public void TryGetHeapVariable(){} // RVA: 0x7A7E029D0
        public void GetHeapVariableType(){} // RVA: 0x7A7E00740
        public void GetHeapCapacity(){} // RVA: 0x7A7E00710
        public void DumpHeapObjects(){} // RVA: 0x7A7E18800
    }

    public class IUdonHeapFactory
    {
        // ── Methods ──
        public void ConstructUdonHeap(){} // RVA: 0x7A7E00740
    }

    public class IUdonProgram
    {
        // ── Methods ──
        public void get_InstructionSetIdentifier(){} // RVA: 0x7A7E00680
        public void get_InstructionSetVersion(){} // RVA: 0x7A7E00710
        public void get_ByteCode(){} // RVA: 0x7A7E00680
        public void get_Heap(){} // RVA: 0x7A7E00680
        public void get_EntryPoints(){} // RVA: 0x7A7E00680
        public void get_SymbolTable(){} // RVA: 0x7A7E00680
        public void get_SyncMetadataTable(){} // RVA: 0x7A7E00680
        public void get_UpdateOrder(){} // RVA: 0x7A7E00710
    }

    public class IUdonProgramVariableAccessTarget
    {
        // ── Methods ──
        public void GetProgramVariableType(){} // RVA: 0x7A7E00B20
        public void GetProgramVariable(){} // RVA: 0x7A7E00B20
        public void TryGetProgramVariable(){} // RVA: 0x7A7E01A40
        public void SetProgramVariable(){} // RVA: 0x7A7E18890
    }

    public class IUdonSecurityFilter
    {
        // ── Methods ──
        public void ApplyFilter(){} // RVA: 0x7A7E18800
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7A7E18800
        public void get_LightReservedLayerMask(){} // RVA: 0x7A7E00710
        public void set_LightReservedLayerMask(){} // RVA: 0x7A7E189D0
    }

    public class IUdonSecurityFilter`1
    {
        // ── Methods ──
        public void ApplyFilter(){} // RVA: 0x7A7E18800
    }

    public class IUdonSecurityFilter`1
    {
        // ── Methods ──
        public void ApplyFilter(){} // RVA: 0x7A7E18800
    }

    public class IUdonSymbol
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A7E00680
        public void get_Type(){} // RVA: 0x7A7E00680
        public void get_Address(){} // RVA: 0x7A7E00710
    }

    public class IUdonSymbolTable
    {
        // ── Methods ──
        public void HasAddressForSymbol(){} // RVA: 0x7A7E019D0
        public void HasSymbolForAddress(){} // RVA: 0x7A7E01F00
        public void GetSymbolFromAddress(){} // RVA: 0x7A7E00740
        public void TryGetSymbolFromAddress(){} // RVA: 0x7A7E029D0
        public void GetAddressFromSymbol(){} // RVA: 0x7A7E01630
        public void TryGetAddressFromSymbol(){} // RVA: 0x7A7E01A40
        public void GetExportedSymbols(){} // RVA: 0x7A7E00680
        public void GetSymbols(){} // RVA: 0x7A7E00680
        public void HasExportedSymbol(){} // RVA: 0x7A7E019D0
        public void GetSymbolType(){} // RVA: 0x7A7E00B20
    }

    public class IUdonSymbol[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class IUdonSyncMetadata
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A7E00680
        public void get_Properties(){} // RVA: 0x7A7E00680
    }

    public class IUdonSyncMetadataTable
    {
        // ── Methods ──
        public void GetAllSyncMetadata(){} // RVA: 0x7A7E00680
        public void GetSyncMetadataFromSymbol(){} // RVA: 0x7A7E00B20
    }

    public class IUdonSyncMetadata[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class IUdonSyncProperty
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A7E00680
        public void get_InterpolationAlgorithm(){} // RVA: 0x7A7E00710
    }

    public class IUdonSyncTarget
    {
        // ── Methods ──
        public void get_SyncMetadataTable(){} // RVA: 0x7A7E00680
    }

    public class IUdonVM
    {
        // ── Methods ──
        public void LoadProgram(){} // RVA: 0x7A7E019D0
        public void RetrieveProgram(){} // RVA: 0x7A7E00680
        public void SetProgramCounter(){} // RVA: 0x7A7E189D0
        public void GetProgramCounter(){} // RVA: 0x7A7E00710
        public void Interpret(){} // RVA: 0x7A7E00710
        public void InspectHeap(){} // RVA: 0x7A7E00680
        public void set_DebugLogging(){} // RVA: 0x7A7E18C30
        public void get_DebugLogging(){} // RVA: 0x7A7E01900
    }

    public class IUdonVMFactory
    {
        // ── Methods ──
        public void ConstructUdonVM(){} // RVA: 0x7A7E00680
    }

    public class IUdonVariable
    {
        // ── Methods ──
        public void get_SymbolName(){} // RVA: 0x7A7E00680
        public void get_Value(){} // RVA: 0x7A7E00680
        public void set_Value(){} // RVA: 0x7A7E18800
        public void get_DeclaredType(){} // RVA: 0x7A7E00680
    }

    public class IUdonVariableTable
    {
        // ── Methods ──
        public void get_VariableSymbols(){} // RVA: 0x7A7E00680
        public void TrySetVariableValue(){} // RVA: 0x7A8051B10
        public void TryGetVariableValue(){} // RVA: 0x7A7E01A40
        public void TryGetVariableType(){} // RVA: 0x7A7E01A40
        public void TryAddVariable(){} // RVA: 0x7A7E019D0
        public void RemoveVariable(){} // RVA: 0x7A7E019D0
    }

    public class IUdonVariable[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class IUdonWrapper
    {
        // ── Methods ──
        public void GetExternFunctionParameterCount(){} // RVA: 0x7A7E01630
        public void GetExternFunctionDelegate(){} // RVA: 0x7A7E00B20
        public void RegisterWrapperModule(){} // RVA: 0x7A7E18800
        public void GetWrapperModuleByName(){} // RVA: 0x7A7E00B20
    }

    public class IUdonWrapperFactory
    {
        // ── Methods ──
        public void GetWrapper(){} // RVA: 0x7A7E00680
    }

    public class IUdonWrapperModule
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A7E00680
        public void GetExternFunctionParameterCount(){} // RVA: 0x7A7E01630
        public void GetExternFunctionDelegate(){} // RVA: 0x7A7E00B20
    }

}