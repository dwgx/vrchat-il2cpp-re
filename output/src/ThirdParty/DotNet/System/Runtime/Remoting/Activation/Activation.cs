// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Activation
// Classes: 9
// Methods: 30

namespace ThirdParty.DotNet.System.Runtime.Remoting.Activation
{
    public class ActivationServices
    {
        public System.Runtime.Remoting.Activation.IActivator NextActivator;

        // ── Methods ──
        public void get_ConstructionActivator(){} // RVA: 0x5CEF780
        public void Activate(){} // RVA: 0x5CEF860
        public void RemoteActivate(){} // RVA: 0x5CEFAB0
        public void CreateConstructionCall(){} // RVA: 0x5CEFB70
        public void CreateInstanceFromMessage(){} // RVA: 0x5CF0560
        public void CreateProxyForType(){} // RVA: 0x5CF0660
        public void AllocateUninitializedClassInstance(){} // RVA: 0x5CF08C0
        public void EnableProxyActivation(){} // RVA: 0x5CF0900
    }

    public class AppDomainLevelActivator
    {
        public string _activationUrl; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void get_NextActivator(){} // RVA: 0x2E07C0
        public void Activate(){} // RVA: 0x5CF0910
    }

    public class ConstructionLevelActivator
    {
        // ── Methods ──
        public void get_NextActivator(){} // RVA: 0x519240
        public void Activate(){} // RVA: 0x5CF0CD0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ContextLevelActivator
    {
        public System.Runtime.Remoting.Activation.IActivator m_NextActivator; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_NextActivator(){} // RVA: 0x2F8380
        public void Activate(){} // RVA: 0x5CF0DA0
    }

    public class IActivator
    {
        // ── Methods ──
        public void get_NextActivator(){} // RVA: 0xCD60
        public void Activate(){} // RVA: 0xCE10
    }

    public class IConstructionCallMessage
    {
        // ── Methods ──
        public void get_ActivationType(){} // RVA: 0xCD60
        public void get_ActivationTypeName(){} // RVA: 0xCD60
        public void get_Activator(){} // RVA: 0xCD60
        public void set_Activator(){} // RVA: 0x24B10
        public void get_CallSiteActivationAttributes(){} // RVA: 0xCD60
        public void get_ContextProperties(){} // RVA: 0xCD60
    }

    public class IConstructionReturnMessage
    {
    }

    public class RemoteActivationAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void IsContextOK(){} // RVA: 0x2DD320
        public void GetPropertiesForNewContext(){} // RVA: 0x5CF1000
    }

    public class RemoteActivator : T<D
    {
        // ── Methods ──
        public void Activate(){} // RVA: 0x5CF1330
        public void get_NextActivator(){} // RVA: 0x5CF15E0
    }

}