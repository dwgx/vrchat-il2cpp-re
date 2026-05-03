// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Proxies
// Classes: 4
// Methods: 37

namespace ThirdParty.DotNet.System.Runtime.Remoting.Proxies
{
    public class ProxyAttribute : Attribute
    {
        // ── Methods ──
        public void CreateInstance(){} // RVA: 0x7FFE86821F30
        public void CreateProxy(){} // RVA: 0x7FFE86822060
        public void GetPropertiesForNewContext(){} // RVA: 0x7FFE810FB310
        public void IsContextOK(){} // RVA: 0x7FFE811E0850
    }

    public class RealProxy : Object
    {
        public System.Type class_to_proxy; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86822C50 | overloaded x4
        public void InternalGetProxyType(){} // RVA: 0x7FFE86822DA0
        public void GetProxiedType(){} // RVA: 0x7FFE86822DB0
        public void GetObjectData(){} // RVA: 0x7FFE86822E50
        public void get_ObjectIdentity(){} // RVA: 0x7FFE8143BA80
        public void set_ObjectIdentity(){} // RVA: 0x7FFE81437330
        public void Invoke(){} // RVA: 0x7FFE80E2E390
        public void PrivateInvoke(){} // RVA: 0x7FFE86822EC0
        public void InternalGetTransparentProxy(){} // RVA: 0x7FFE86823820
        public void GetTransparentProxy(){} // RVA: 0x7FFE86823830
        public void AttachServer(){} // RVA: 0x7FFE811290D0
        public void SetTargetDomain(){} // RVA: 0x7FFE817E4800
        public void GetAppDomainTarget(){} // RVA: 0x7FFE868239E0
        public void ProcessResponse(){} // RVA: 0x7FFE86823B70
    }

    public class RemotingProxy : RealProxy
    {
        public System.Reflection.MethodInfo _cache_GetTypeMethod;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86824340 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFE868243F0
        public void AttachIdentity(){} // RVA: 0x7FFE86824840
        public void ActivateRemoteObject(){} // RVA: 0x7FFE86824E30
        public void get_TypeName(){} // RVA: 0x7FFE86824F20
        public void CanCastTo(){} // RVA: 0x7FFE86825050
        public void Finalize(){} // RVA: 0x7FFE868252A0
        public void .cctor(){} // RVA: 0x7FFE86825370
    }

    public class TransparentProxy : Object
    {
        public System.Runtime.Remoting.Proxies.RealProxy _rp; // 0x10
        public Mono.RuntimeRemoteClassHandle _class; // 0x18

        // ── Methods ──
        public void GetProxyType(){} // RVA: 0x7FFE868220C0
        public void get_IsContextBoundObject(){} // RVA: 0x7FFE868221D0
        public void get_TargetContext(){} // RVA: 0x7FFE8189C080
        public void InCurrentContext(){} // RVA: 0x7FFE868222F0
        public void LoadRemoteFieldNew(){} // RVA: 0x7FFE86822460
        public void StoreRemoteField(){} // RVA: 0x7FFE86822800
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}