// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Common.Interfaces
// Classes: 16
// Methods: 103

namespace VRC.Udon.Common.Interfaces
{
    public class IUdonBehaviour
    {
        // ── Original Methods ──
        public void get_IsNetworkingSupported(){} // RVA: 0x7ffaa864a040
        public void InitializeUdonContent(){} // RVA: 0x7ffaa8660cc0
    }

    public class IUdonComponentGetter
    {
        // ── Binary Analysis Named ──
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
        // ── Original Methods ──
        public void get_GetterType(){} // RVA: 0x7ffaa86491d0
        // ── Binary Analysis Named ──
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
        // ── Original Methods ──
        public void SendCustomEvent(){} // RVA: 0x7ffaa8660d80
        public void SendCustomNetworkEvent(){} // RVA: 0x7ffaa8664240
        public void SendCustomNetworkEvent(){} // RVA: 0x7ffaa8664240
        public void SendCustomNetworkEvent(){} // RVA: 0x7ffaa8664240
        public void SendCustomNetworkEvent(){} // RVA: 0x7ffaa8664240
        public void SendCustomNetworkEvent(){} // RVA: 0x7ffaa8664240
        public void SendCustomNetworkEvent(){} // RVA: 0x7ffaa8664240
        public void SendCustomNetworkEvent(){} // RVA: 0x7ffaa8664240
        public void SendCustomNetworkEvent(){} // RVA: 0x7ffaa8664240
        public void SendCustomNetworkEvent(){} // RVA: 0x7ffaa8664240
        public void RequestSerialization(){} // RVA: 0x7ffaa8660cc0
        public void SendCustomEventDelayedSeconds(){}
        public void SendCustomEventDelayedFrames(){}
        public void get_enabled(){} // RVA: 0x7ffaa864a040
        public void set_enabled(){} // RVA: 0x7ffaa86613a0
        public void get_DisableInteractive(){} // RVA: 0x7ffaa864a040
        public void set_DisableInteractive(){} // RVA: 0x7ffaa86613a0
        public void get_DisableEventProcessing(){} // RVA: 0x7ffaa864a040
        public void set_DisableEventProcessing(){} // RVA: 0x7ffaa86613a0
        public void get_InteractionText(){} // RVA: 0x7ffaa86491d0
        public void set_InteractionText(){} // RVA: 0x7ffaa8660d80
        public void RunProgram(){} // RVA: 0x7ffaa8660d80
        public void RunEvent(){} // RVA: 0x7ffaa864d540
        public void RunEvent(){} // RVA: 0x7ffaa864d540
        public void RunEvent(){} // RVA: 0x7ffaa864d540
        public void RunEvent(){} // RVA: 0x7ffaa864d540
        public void RunEvent(){} // RVA: 0x7ffaa864d540
        public void RunInputEvent(){}
    }

    public class IUdonHeap
    {
        // ── Original Methods ──
        public void InitializeHeapVariable(){} // RVA: 0x7ffaa8661210
        public void InitializeHeapVariable(){} // RVA: 0x7ffaa8661210
        public void IsHeapVariableInitialized(){} // RVA: 0x7ffaa864a650
        public void CopyHeapVariable(){}
        public void TryGetHeapVariable(){}
        public void TryGetHeapVariable(){}
        public void DumpHeapObjects(){} // RVA: 0x7ffaa8660d80
        // ── Binary Analysis Named ──
        public void SetHeapVariable(){} // RVA: 0x7ffaa887e5c0
        public void SetHeapVariable(){} // RVA: 0x7ffaa887e5c0
        public void GetHeapVariable(){} // RVA: 0x7ffaa887e5c0
        public void GetHeapVariable(){} // RVA: 0x7ffaa887e5c0
        public void GetHeapVariableType(){}
        public void GetHeapCapacity(){} // RVA: 0x7ffaa8649ca0
    }

    public class IUdonProgramVariableAccessTarget
    {
        // ── Original Methods ──
        public void TryGetProgramVariable(){} // RVA: 0x7ffaa864d540
        public void TryGetProgramVariable(){} // RVA: 0x7ffaa864d540
        // ── Binary Analysis Named ──
        public void GetProgramVariableType(){} // RVA: 0x7ffaa8649280
        public void GetProgramVariable(){} // RVA: 0x7ffaa8649280
        public void GetProgramVariable(){} // RVA: 0x7ffaa8649280
        public void SetProgramVariable(){} // RVA: 0x7ffaa8669e70
        public void SetProgramVariable(){} // RVA: 0x7ffaa8669e70
    }

    public class IUdonSecurityFilter
    {
        // ── Original Methods ──
        public void ApplyFilter(){} // RVA: 0x7ffaa8660d80
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7ffaa8660d80
        public void get_LightReservedLayerMask(){} // RVA: 0x7ffaa8649ca0
        public void set_LightReservedLayerMask(){} // RVA: 0x7ffaa8661210
    }

    public class IUdonSecurityFilter`1
    {
        // ── Original Methods ──
        public void ApplyFilter(){} // RVA: 0x7ffaa8660d80
    }

    public class IUdonSecurityFilter`1
    {
        // ── Original Methods ──
        public void ApplyFilter(){} // RVA: 0x7ffaa8660d80
    }

    public class IUdonSecurityFilter`1
    {
    }

    public class IUdonSyncTarget
    {
        // ── Original Methods ──
        public void get_SyncMetadataTable(){} // RVA: 0x7ffaa86491d0
    }

    public class IUdonVMFactory
    {
        // ── Original Methods ──
        public void ConstructUdonVM(){} // RVA: 0x7ffaa86491d0
    }

    public class IUdonVariableTable
    {
        // ── Original Methods ──
        public void get_VariableSymbols(){} // RVA: 0x7ffaa86491d0
        public void TrySetVariableValue(){} // RVA: 0x7ffaa887e5c0
        public void TrySetVariableValue(){} // RVA: 0x7ffaa887e5c0
        public void TryGetVariableValue(){} // RVA: 0x7ffaa864d540
        public void TryGetVariableValue(){} // RVA: 0x7ffaa864d540
        public void TryGetVariableType(){} // RVA: 0x7ffaa864d540
        public void TryAddVariable(){} // RVA: 0x7ffaa864a2a0
        public void RemoveVariable(){} // RVA: 0x7ffaa864a2a0
    }

    public class IUdonWrapper
    {
        // ── Original Methods ──
        public void RegisterWrapperModule(){} // RVA: 0x7ffaa8660d80
        // ── Binary Analysis Named ──
        public void GetExternFunctionParameterCount(){} // RVA: 0x7ffaa864e9f0
        public void GetExternFunctionDelegate(){} // RVA: 0x7ffaa8649280
        public void GetWrapperModuleByName(){} // RVA: 0x7ffaa8649280
    }

    public class IUdonWrapperFactory
    {
        // ── Binary Analysis Named ──
        public void GetWrapper(){} // RVA: 0x7ffaa86491d0
    }

    public class IUdonWrapperModule
    {
        // ── Original Methods ──
        public void get_Name(){} // RVA: 0x7ffaa86491d0
        // ── Binary Analysis Named ──
        public void GetExternFunctionParameterCount(){} // RVA: 0x7ffaa864e9f0
        public void GetExternFunctionDelegate(){} // RVA: 0x7ffaa8649280
    }

}