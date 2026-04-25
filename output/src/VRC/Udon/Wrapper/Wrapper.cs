// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Wrapper
// Classes: 2
// Methods: 24

namespace VRC.Udon.Wrapper
{
    public class UdonDefaultWrapperFactory : Object
    {
        public System.Collections.Generic.HashSet`1<System.Type> _wrapperModuleTypes; // 0x10
        public VRC.Udon.Common.Interfaces.IUdonWrapper _udonWrapper; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACA2C3D90
        public void GetWrapperModuleTypesFromAttribute(){} // RVA: 0x7FFACA2C4290
        public void GetWrapper(){} // RVA: 0x7FFAC2F247C0
        public void RegisterWrapperModule(){} // RVA: 0x7FFACA2C45F0
        public void CreateWrapperModule(){} // RVA: 0x7FFACA2C4820
    }

    public class UdonWrapper : Object
    {
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,VRC.Udon.Common.Interfaces.IUdonWrapperModule> _wrapperModulesByName; // 0x10
        public System.Collections.Concurrent.ConcurrentDictionary`2<System.Type,VRC.Udon.Common.Interfaces.IUdonComponentGetterModule> _componentGetterModules; // 0x18

        // ── Methods ──
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA2C4980
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA2C4B90
        public void RegisterWrapperModule(){} // RVA: 0x7FFACA2C4DA0
        public void GetWrapperModuleByName(){} // RVA: 0x7FFACA2C5200
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponent__T(){} // RVA: 0x7FFACA2C5330
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponentInChildren__T(){} // RVA: 0x7FFACA2C5480
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA2C55D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponentInParent__T(){} // RVA: 0x7FFACA2C5720
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA2C5870
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponents__TArray(){} // RVA: 0x7FFACA2C59C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA2C5B10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA2C5C60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA2C5DB0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA2C5F00
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA2C6050
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA2C61A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA2C62F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetter.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA2C6440
        public void .ctor(){} // RVA: 0x7FFACA2C6590
    }

}