// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Activation
// Classes: 8
// Methods: 30

namespace ThirdParty.DotNet.System.Runtime.Remoting.Activation
{
    public class ActivationServices : Object
    {
        public object _constructionActivator;

        // ── Methods ──
        public void get_ConstructionActivator(){} // RVA: 0x67680B0
        public void Activate(){} // RVA: 0x6768190
        public void RemoteActivate(){} // RVA: 0x67683E0
        public void CreateConstructionCall(){} // RVA: 0x67684A0
        public void CreateInstanceFromMessage(){} // RVA: 0x6768EB0
        public void CreateProxyForType(){} // RVA: 0x6768FB0
        public void AllocateUninitializedClassInstance(){} // RVA: 0x6769210
        public void EnableProxyActivation(){} // RVA: 0x6769250
    }

    public class AppDomainLevelActivator : Object
    {
        public object _activationUrl;
        public object _next;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_NextActivator(){} // RVA: 0xB465B0
        public void Activate(){} // RVA: 0x6769260
    }

    public class ConstructionLevelActivator : Object
    {
        // ── Methods ──
        public void get_NextActivator(){} // RVA: 0xDAC980
        public void Activate(){} // RVA: 0x67695F0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ContextLevelActivator : Object
    {
        public object m_NextActivator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_NextActivator(){} // RVA: 0xB5DBF0
        public void Activate(){} // RVA: 0x67696C0
    }

    public class IActivator
    {
        // ── Methods ──
        public void get_NextActivator(){} // RVA: 0x87C0A0
        public void Activate(){} // RVA: 0x87C540
    }

    public class IConstructionCallMessage
    {
        // ── Methods ──
        public void get_ActivationType(){} // RVA: 0x87C0A0
        public void get_ActivationTypeName(){} // RVA: 0x87C0A0
        public void get_Activator(){} // RVA: 0x87C0A0
        public void set_Activator(){} // RVA: 0x894320
        public void get_CallSiteActivationAttributes(){} // RVA: 0x87C0A0
        public void get_ContextProperties(){} // RVA: 0x87C0A0
    }

    public class RemoteActivationAttribute : Attribute
    {
        public object _contextProperties;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void IsContextOK(){} // RVA: 0xB43320
        public void GetPropertiesForNewContext(){} // RVA: 0x6769920
    }

    public class RemoteActivator : MarshalByRefObject
    {
        // ── Methods ──
        public void Activate(){} // RVA: 0x6769C50
        public void get_NextActivator(){} // RVA: 0x6769F00
    }

}