// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Proxies
// Classes: 4
// Methods: 33

namespace ThirdParty.DotNet.System.Runtime.Remoting.Proxies
{
    public class ProxyAttribute : Attribute
    {
        // ── Methods ──
        public void CreateInstance(){} // RVA: 0x7ADACEE10
        public void CreateProxy(){} // RVA: 0x7ADACEF40
        public void GetPropertiesForNewContext(){} // RVA: 0x7A80D7310
        public void IsContextOK(){} // RVA: 0x7A81BD750
    }

    public class RealProxy : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADACFB20
        public void InternalGetProxyType(){} // RVA: 0x7ADACFC70
        public void GetProxiedType(){} // RVA: 0x7ADACFC80
        public void GetObjectData(){} // RVA: 0x7ADACFD20
        public void get_ObjectIdentity(){} // RVA: 0x7A8292C30
        public void set_ObjectIdentity(){} // RVA: 0x7A8296DE0
        public void Invoke(){} // RVA: 0x7A7E00B20
        public void PrivateInvoke(){} // RVA: 0x7ADACFD90
        public void InternalGetTransparentProxy(){} // RVA: 0x7ADAD0700
        public void GetTransparentProxy(){} // RVA: 0x7ADAD0710
        public void AttachServer(){} // RVA: 0x7A81052D0
        public void SetTargetDomain(){} // RVA: 0x7A8810F60
        public void GetAppDomainTarget(){} // RVA: 0x7ADAD08C0
        public void ProcessResponse(){} // RVA: 0x7ADAD0A40
    }

    public class RemotingProxy : RealProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAD1220
        public void Invoke(){} // RVA: 0x7ADAD12D0
        public void AttachIdentity(){} // RVA: 0x7ADAD1710
        public void ActivateRemoteObject(){} // RVA: 0x7ADAD1C80
        public void get_TypeName(){} // RVA: 0x7ADAD1D70
        public void CanCastTo(){} // RVA: 0x7ADAD1EA0
        public void Finalize(){} // RVA: 0x7ADAD20F0
        public void .cctor(){} // RVA: 0x7ADAD21C0
    }

    public class TransparentProxy : Object
    {
        // ── Methods ──
        public void GetProxyType(){} // RVA: 0x7ADACEFA0
        public void get_IsContextBoundObject(){} // RVA: 0x7ADACF0B0
        public void get_TargetContext(){} // RVA: 0x7A88F4330
        public void InCurrentContext(){} // RVA: 0x7ADACF1C0
        public void LoadRemoteFieldNew(){} // RVA: 0x7ADACF330
        public void StoreRemoteField(){} // RVA: 0x7ADACF6D0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}