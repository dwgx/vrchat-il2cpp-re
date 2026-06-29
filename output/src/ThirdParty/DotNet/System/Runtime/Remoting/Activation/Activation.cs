// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Activation
// Classes: 8
// Methods: 30

namespace ThirdParty.DotNet.System.Runtime.Remoting.Activation
{
    public class ActivationServices : Object
    {
        // ── Methods ──
        public void get_ConstructionActivator(){} // RVA: 0x7ADADD180
        public void Activate(){} // RVA: 0x7ADADD260
        public void RemoteActivate(){} // RVA: 0x7ADADD4B0
        public void CreateConstructionCall(){} // RVA: 0x7ADADD570
        public void CreateInstanceFromMessage(){} // RVA: 0x7ADADDF80
        public void CreateProxyForType(){} // RVA: 0x7ADADE080
        public void AllocateUninitializedClassInstance(){} // RVA: 0x7ADADE470
        public void EnableProxyActivation(){} // RVA: 0x7ADADE4B0
    }

    public class AppDomainLevelActivator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_NextActivator(){} // RVA: 0x7A80DA7B0
        public void Activate(){} // RVA: 0x7ADADE4C0
    }

    public class ConstructionLevelActivator : Object
    {
        // ── Methods ──
        public void get_NextActivator(){} // RVA: 0x7A82D1450
        public void Activate(){} // RVA: 0x7ADADE880
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ContextLevelActivator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_NextActivator(){} // RVA: 0x7A80F2570
        public void Activate(){} // RVA: 0x7ADADE950
    }

    public class IActivator
    {
        // ── Methods ──
        public void get_NextActivator(){} // RVA: 0x7A7E00680
        public void Activate(){} // RVA: 0x7A7E00B20
    }

    public class IConstructionCallMessage
    {
        // ── Methods ──
        public void get_ActivationType(){} // RVA: 0x7A7E00680
        public void get_ActivationTypeName(){} // RVA: 0x7A7E00680
        public void get_Activator(){} // RVA: 0x7A7E00680
        public void set_Activator(){} // RVA: 0x7A7E18800
        public void get_CallSiteActivationAttributes(){} // RVA: 0x7A7E00680
        public void get_ContextProperties(){} // RVA: 0x7A7E00680
    }

    public class RemoteActivationAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void IsContextOK(){} // RVA: 0x7A80D7320
        public void GetPropertiesForNewContext(){} // RVA: 0x7ADADEBB0
    }

    public class RemoteActivator : MarshalByRefObject
    {
        // ── Methods ──
        public void Activate(){} // RVA: 0x7ADADEEE0
        public void get_NextActivator(){} // RVA: 0x7ADADF190
    }

}