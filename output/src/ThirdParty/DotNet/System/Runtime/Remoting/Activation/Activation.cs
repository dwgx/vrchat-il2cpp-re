// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Activation
// Classes: 9
// Methods: 30

namespace ThirdParty.DotNet.System.Runtime.Remoting.Activation
{
    public class ActivationServices : Object
    {
        public System.Runtime.Remoting.Activation.IActivator ConstructionActivator;

        // ── Methods ──
        public void get_ConstructionActivator(){} // RVA: 0x7FFAC8486D70
        public void Activate(){} // RVA: 0x7FFAC8486E50
        public void RemoteActivate(){} // RVA: 0x7FFAC84870A0
        public void CreateConstructionCall(){} // RVA: 0x7FFAC8487160
        public void CreateInstanceFromMessage(){} // RVA: 0x7FFAC8487B50
        public void CreateProxyForType(){} // RVA: 0x7FFAC8487C50
        public void AllocateUninitializedClassInstance(){} // RVA: 0x7FFAC8487EB0
        public void EnableProxyActivation(){} // RVA: 0x7FFAC8487EF0
    }

    public class AppDomainLevelActivator : Object
    {
        public string NextActivator; // 0x10
        public System.Runtime.Remoting.Activation.IActivator _next; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void get_NextActivator(){} // RVA: 0x7FFAC2F247C0
        public void Activate(){} // RVA: 0x7FFAC8487F00
    }

    public class ConstructionLevelActivator : Object
    {
        public object NextActivator;

        // ── Methods ──
        public void get_NextActivator(){} // RVA: 0x7FFAC34F9180
        public void Activate(){} // RVA: 0x7FFAC84882C0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ContextLevelActivator : Object
    {
        public System.Runtime.Remoting.Activation.IActivator NextActivator; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_NextActivator(){} // RVA: 0x7FFAC2F3C380
        public void Activate(){} // RVA: 0x7FFAC8488390
    }

    public class IActivator
    {
        public object NextActivator;

        // ── Methods ──
        public void get_NextActivator(){} // RVA: 0x7FFAC2C58E90
        public void Activate(){} // RVA: 0x7FFAC2C58F40
    }

    public class IConstructionCallMessage
    {
        public object ActivationType;
        public object ActivationTypeName;
        public object Activator;
        public object CallSiteActivationAttributes;
        public object ContextProperties;

        // ── Methods ──
        public void get_ActivationType(){} // RVA: 0x7FFAC2C58E90
        public void get_ActivationTypeName(){} // RVA: 0x7FFAC2C58E90
        public void get_Activator(){} // RVA: 0x7FFAC2C58E90
        public void set_Activator(){} // RVA: 0x7FFAC2C70A40
        public void get_CallSiteActivationAttributes(){} // RVA: 0x7FFAC2C58E90
        public void get_ContextProperties(){} // RVA: 0x7FFAC2C58E90
    }

    public class IConstructionReturnMessage
    {
    }

    public class RemoteActivationAttribute : Attribute
    {
        public System.Collections.IList _contextProperties; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void IsContextOK(){} // RVA: 0x7FFAC2F21320
        public void GetPropertiesForNewContext(){} // RVA: 0x7FFAC84885F0
    }

    public class RemoteActivator : MarshalByRefObject
    {
        public object NextActivator;

        // ── Methods ──
        public void Activate(){} // RVA: 0x7FFAC8488920
        public void get_NextActivator(){} // RVA: 0x7FFAC8488BD0
    }

}