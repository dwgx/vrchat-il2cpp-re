// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Proxies
// Classes: 4
// Methods: 37

namespace ThirdParty.DotNet.System.Runtime.Remoting.Proxies
{
    public class ProxyAttribute
    {
        // ── Methods ──
        public void CreateInstance(){} // RVA: 0x5CE1030
        public void CreateProxy(){} // RVA: 0x5CE1160
        public void GetPropertiesForNewContext(){} // RVA: 0x2DD310
        public void IsContextOK(){} // RVA: 0x3C2850
    }

    public class RealProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CE1D50 | overloaded x4
        public void InternalGetProxyType(){} // RVA: 0x5CE1EA0
        public void GetProxiedType(){} // RVA: 0x5CE1EB0
        public void GetObjectData(){} // RVA: 0x5CE1F50
        public void get_ObjectIdentity(){} // RVA: 0x4976A0
        public void set_ObjectIdentity(){} // RVA: 0x49B830
        public void Invoke(){} // RVA: 0xCE10
        public void PrivateInvoke(){} // RVA: 0x5CE1FC0
        public void InternalGetTransparentProxy(){} // RVA: 0x5CE2920
        public void GetTransparentProxy(){} // RVA: 0x5CE2930
        public void AttachServer(){} // RVA: 0x30B0D0
        public void SetTargetDomain(){} // RVA: 0xA53440
        public void GetAppDomainTarget(){} // RVA: 0x5CE2AE0
        public void ProcessResponse(){} // RVA: 0x5CE2C70
    }

    public class RemotingProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CE3440 | overloaded x2
        public void Invoke(){} // RVA: 0x5CE34F0
        public void AttachIdentity(){} // RVA: 0x5CE3940
        public void ActivateRemoteObject(){} // RVA: 0x5CE3F30
        public void get_TypeName(){} // RVA: 0x5CE4020
        public void CanCastTo(){} // RVA: 0x5CE4150
        public void Finalize(){} // RVA: 0x5CE43A0
        public void .cctor(){} // RVA: 0x5CE4470
    }

    public class TransparentProxy
    {
        public object ObjectIdentity;

        // ── Methods ──
        public void GetProxyType(){} // RVA: 0x5CE11C0
        public void get_IsContextBoundObject(){} // RVA: 0x5CE12D0
        public void get_TargetContext(){} // RVA: 0xB2EEA0
        public void InCurrentContext(){} // RVA: 0x5CE13F0
        public void LoadRemoteFieldNew(){} // RVA: 0x5CE1560
        public void StoreRemoteField(){} // RVA: 0x5CE1900
        public void .ctor(){} // RVA: 0x2DD310
    }

}