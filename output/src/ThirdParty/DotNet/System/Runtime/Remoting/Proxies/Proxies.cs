// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Proxies
// Classes: 4
// Methods: 37

namespace ThirdParty.DotNet.System.Runtime.Remoting.Proxies
{
    public class ProxyAttribute : Attribute
    {
        // ── Methods ──
        public void CreateInstance(){} // RVA: 0x7FFAC8478620
        public void CreateProxy(){} // RVA: 0x7FFAC8478750
        public void GetPropertiesForNewContext(){} // RVA: 0x7FFAC2F21310
        public void IsContextOK(){} // RVA: 0x7FFAC3006850
    }

    public class RealProxy : Object
    {
        public System.Type ObjectIdentity; // 0x10
        public System.Runtime.Remoting.Contexts.Context _targetContext; // 0x18
        public System.MarshalByRefObject _server; // 0x20
        public int _targetDomainId; // 0x28
        public string _targetUri; // 0x30
        public System.Runtime.Remoting.Identity _objectIdentity; // 0x38
        public object _objTP; // 0x40
        public object _stubData; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8479340 | overloaded x4
        public void InternalGetProxyType(){} // RVA: 0x7FFAC8479490
        public void GetProxiedType(){} // RVA: 0x7FFAC84794A0
        public void GetObjectData(){} // RVA: 0x7FFAC8479540
        public void get_ObjectIdentity(){} // RVA: 0x7FFAC31D0140
        public void set_ObjectIdentity(){} // RVA: 0x7FFAC31D0C20
        public void Invoke(){} // RVA: 0x7FFAC2C58F40
        public void PrivateInvoke(){} // RVA: 0x7FFAC84795B0
        public void InternalGetTransparentProxy(){} // RVA: 0x7FFAC8479F10
        public void GetTransparentProxy(){} // RVA: 0x7FFAC8479F20
        public void AttachServer(){} // RVA: 0x7FFAC2F4F0D0
        public void SetTargetDomain(){} // RVA: 0x7FFAC369A6E0
        public void GetAppDomainTarget(){} // RVA: 0x7FFAC847A0D0
        public void ProcessResponse(){} // RVA: 0x7FFAC847A260
    }

    public class RemotingProxy : RealProxy
    {
        public System.Reflection.MethodInfo TypeName;
        public System.Reflection.MethodInfo _cache_GetHashCodeMethod; // 0x8
        public System.Runtime.Remoting.Messaging.IMessageSink _sink; // 0x50
        public bool _hasEnvoySink; // 0x58
        public System.Runtime.Remoting.Messaging.ConstructionCall _ctorCall; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC847AA30 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFAC847AAE0
        public void AttachIdentity(){} // RVA: 0x7FFAC847AF30
        public void ActivateRemoteObject(){} // RVA: 0x7FFAC847B520
        public void get_TypeName(){} // RVA: 0x7FFAC847B610
        public void CanCastTo(){} // RVA: 0x7FFAC847B740
        public void Finalize(){} // RVA: 0x7FFAC847B990
        public void .cctor(){} // RVA: 0x7FFAC847BA60
    }

    public class TransparentProxy : Object
    {
        public System.Runtime.Remoting.Proxies.RealProxy IsContextBoundObject; // 0x10
        public Mono.RuntimeRemoteClassHandle TargetContext; // 0x18
        public bool _custom_type_info; // 0x20

        // ── Methods ──
        public void GetProxyType(){} // RVA: 0x7FFAC84787B0
        public void get_IsContextBoundObject(){} // RVA: 0x7FFAC84788C0
        public void get_TargetContext(){} // RVA: 0x7FFAC356B610
        public void InCurrentContext(){} // RVA: 0x7FFAC84789E0
        public void LoadRemoteFieldNew(){} // RVA: 0x7FFAC8478B50
        public void StoreRemoteField(){} // RVA: 0x7FFAC8478EF0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}