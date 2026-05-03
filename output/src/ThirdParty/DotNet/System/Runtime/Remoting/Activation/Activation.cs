// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Activation
// Classes: 9
// Methods: 30

namespace ThirdParty.DotNet.System.Runtime.Remoting.Activation
{
    public class ActivationServices : Object
    {
        public System.Runtime.Remoting.Activation.IActivator _constructionActivator;

        // ── Methods ──
        public void get_ConstructionActivator(){} // RVA: 0x7FFE86830680
        public void Activate(){} // RVA: 0x7FFE86830760
        public void RemoteActivate(){} // RVA: 0x7FFE868309B0
        public void CreateConstructionCall(){} // RVA: 0x7FFE86830A70
        public void CreateInstanceFromMessage(){} // RVA: 0x7FFE86831460
        public void CreateProxyForType(){} // RVA: 0x7FFE86831560
        public void AllocateUninitializedClassInstance(){} // RVA: 0x7FFE868317C0
        public void EnableProxyActivation(){} // RVA: 0x7FFE86831800
    }

    public class AppDomainLevelActivator : Object
    {
        public string _activationUrl; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void get_NextActivator(){} // RVA: 0x7FFE810FE7C0
        public void Activate(){} // RVA: 0x7FFE86831810
    }

    public class ConstructionLevelActivator : Object
    {
        // ── Methods ──
        public void get_NextActivator(){} // RVA: 0x7FFE813240E0
        public void Activate(){} // RVA: 0x7FFE86831BD0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ContextLevelActivator : Object
    {
        public System.Runtime.Remoting.Activation.IActivator m_NextActivator; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_NextActivator(){} // RVA: 0x7FFE81116380
        public void Activate(){} // RVA: 0x7FFE86831CA0
    }

    public class IActivator
    {
        // ── Methods ──
        public void get_NextActivator(){} // RVA: 0x7FFE80E2E2E0
        public void Activate(){} // RVA: 0x7FFE80E2E390
    }

    public class IConstructionCallMessage
    {
        // ── Methods ──
        public void get_ActivationType(){} // RVA: 0x7FFE80E2E2E0
        public void get_ActivationTypeName(){} // RVA: 0x7FFE80E2E2E0
        public void get_Activator(){} // RVA: 0x7FFE80E2E2E0
        public void set_Activator(){} // RVA: 0x7FFE80E460A0
        public void get_CallSiteActivationAttributes(){} // RVA: 0x7FFE80E2E2E0
        public void get_ContextProperties(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IConstructionReturnMessage
    {
    }

    public class RemoteActivationAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void IsContextOK(){} // RVA: 0x7FFE810FB320
        public void GetPropertiesForNewContext(){} // RVA: 0x7FFE86831F00
    }

    public class RemoteActivator : MarshalByRefObject
    {
        // ── Methods ──
        public void Activate(){} // RVA: 0x7FFE86832230
        public void get_NextActivator(){} // RVA: 0x7FFE868324E0
    }

}