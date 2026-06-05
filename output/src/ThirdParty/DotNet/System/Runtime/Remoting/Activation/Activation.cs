// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Activation
// Classes: 9
// Methods: 30

namespace ThirdParty.DotNet.System.Runtime.Remoting.Activation
{
    public class ActivationServices
    {
        public object NextActivator;

        // ── Methods ──
        public void get_ConstructionActivator(){} // RVA: 0x7FFAF879F780
        public void Activate(){} // RVA: 0x7FFAF879F860
        public void RemoteActivate(){} // RVA: 0x7FFAF879FAB0
        public void CreateConstructionCall(){} // RVA: 0x7FFAF879FB70
        public void CreateInstanceFromMessage(){} // RVA: 0x7FFAF87A0560
        public void CreateProxyForType(){} // RVA: 0x7FFAF87A0660
        public void AllocateUninitializedClassInstance(){} // RVA: 0x7FFAF87A08C0
        public void EnableProxyActivation(){} // RVA: 0x7FFAF87A0900
    }

    public class AppDomainLevelActivator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void get_NextActivator(){} // RVA: 0x7FFAF2D907C0
        public void Activate(){} // RVA: 0x7FFAF87A0910
    }

    public class ConstructionLevelActivator
    {
        // ── Methods ──
        public void get_NextActivator(){} // RVA: 0x7FFAF2FC9240
        public void Activate(){} // RVA: 0x7FFAF87A0CD0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ContextLevelActivator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void get_NextActivator(){} // RVA: 0x7FFAF2DA8380
        public void Activate(){} // RVA: 0x7FFAF87A0DA0
    }

    public class IActivator
    {
        // ── Methods ──
        public void get_NextActivator(){} // RVA: 0x7FFAF2ABCD60
        public void Activate(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IConstructionCallMessage
    {
        // ── Methods ──
        public void get_ActivationType(){} // RVA: 0x7FFAF2ABCD60
        public void get_ActivationTypeName(){} // RVA: 0x7FFAF2ABCD60
        public void get_Activator(){} // RVA: 0x7FFAF2ABCD60
        public void set_Activator(){} // RVA: 0x7FFAF2AD4B10
        public void get_CallSiteActivationAttributes(){} // RVA: 0x7FFAF2ABCD60
        public void get_ContextProperties(){} // RVA: 0x7FFAF2ABCD60
    }

    public class IConstructionReturnMessage
    {
    }

    public class RemoteActivationAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void IsContextOK(){} // RVA: 0x7FFAF2D8D320
        public void GetPropertiesForNewContext(){} // RVA: 0x7FFAF87A1000
    }

    public class RemoteActivator : T<D
    {
        // ── Methods ──
        public void Activate(){} // RVA: 0x7FFAF87A1330
        public void get_NextActivator(){} // RVA: 0x7FFAF87A15E0
    }

}