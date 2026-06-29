// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Wrapper
// Classes: 2
// Methods: 24

namespace VRC.Udon.Wrapper
{
    public class UdonDefaultWrapperFactory : Object
    {
        public object _wrapperModuleTypes;
        public object _udonWrapper;
        public object _filter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x87A8FC0
        public void GetWrapperModuleTypesFromAttribute(){} // RVA: 0x87A94C0
        public void GetWrapper(){} // RVA: 0xB465B0
        public void RegisterWrapperModule(){} // RVA: 0x87A97D0
        public void CreateWrapperModule(){} // RVA: 0x87A99E0
    }

    public class UdonWrapper : Object
    {
        public object _wrapperModulesByName;
        public object _componentGetterModules;

        // ── Methods ──
        public void GetExternFunctionParameterCount(){} // RVA: 0x87A9B40
        public void GetExternFunctionDelegate(){} // RVA: 0x87A9D50
        public void RegisterWrapperModule(){} // RVA: 0x87A9F60
        public void GetWrapperModuleByName(){} // RVA: 0x87AA390
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponent__T(){} // RVA: 0x87AA4C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponentInChildren__T(){} // RVA: 0x87AA610
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x87AA760
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponentInParent__T(){} // RVA: 0x87AA8B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x87AAA00
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponents__TArray(){} // RVA: 0x87AAB50
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponents__ListT__SystemVoid(){} // RVA: 0x87AACA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x87AADF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x87AAF40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponentsInChildren__TArray(){} // RVA: 0x87AB090
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x87AB1E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x87AB330
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x87AB480
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponentsInParent__TArray(){} // RVA: 0x87AB5D0
        public void .ctor(){} // RVA: 0x87AB720
    }

}