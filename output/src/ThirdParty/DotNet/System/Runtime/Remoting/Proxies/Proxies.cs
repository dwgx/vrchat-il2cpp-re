// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Proxies
// Classes: 4
// Methods: 37

namespace ThirdParty.DotNet.System.Runtime.Remoting.Proxies
{
    public class ProxyAttribute
    {
        // ── Methods ──
        public void CreateInstance(){} // RVA: 0x7FFAF8791030
        public void CreateProxy(){} // RVA: 0x7FFAF8791160
        public void GetPropertiesForNewContext(){} // RVA: 0x7FFAF2D8D310
        public void IsContextOK(){} // RVA: 0x7FFAF2E72850
    }

    public class RealProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8791D50 | overloaded x4
        public void InternalGetProxyType(){} // RVA: 0x7FFAF8791EA0
        public void GetProxiedType(){} // RVA: 0x7FFAF8791EB0
        public void GetObjectData(){} // RVA: 0x7FFAF8791F50
        public void get_ObjectIdentity(){} // RVA: 0x7FFAF2F476A0
        public void set_ObjectIdentity(){} // RVA: 0x7FFAF2F4B830
        public void Invoke(){} // RVA: 0x7FFAF2ABCE10
        public void PrivateInvoke(){} // RVA: 0x7FFAF8791FC0
        public void InternalGetTransparentProxy(){} // RVA: 0x7FFAF8792920
        public void GetTransparentProxy(){} // RVA: 0x7FFAF8792930
        public void AttachServer(){} // RVA: 0x7FFAF2DBB0D0
        public void SetTargetDomain(){} // RVA: 0x7FFAF3503440
        public void GetAppDomainTarget(){} // RVA: 0x7FFAF8792AE0
        public void ProcessResponse(){} // RVA: 0x7FFAF8792C70
    }

    public class RemotingProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8793440 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFAF87934F0
        public void AttachIdentity(){} // RVA: 0x7FFAF8793940
        public void ActivateRemoteObject(){} // RVA: 0x7FFAF8793F30
        public void get_TypeName(){} // RVA: 0x7FFAF8794020
        public void CanCastTo(){} // RVA: 0x7FFAF8794150
        public void Finalize(){} // RVA: 0x7FFAF87943A0
        public void .cctor(){} // RVA: 0x7FFAF8794470
    }

    public class TransparentProxy
    {
        public object ObjectIdentity;

        // ── Methods ──
        public void GetProxyType(){} // RVA: 0x7FFAF87911C0
        public void get_IsContextBoundObject(){} // RVA: 0x7FFAF87912D0
        public void get_TargetContext(){} // RVA: 0x7FFAF35DEEA0
        public void InCurrentContext(){} // RVA: 0x7FFAF87913F0
        public void LoadRemoteFieldNew(){} // RVA: 0x7FFAF8791560
        public void StoreRemoteField(){} // RVA: 0x7FFAF8791900
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

}