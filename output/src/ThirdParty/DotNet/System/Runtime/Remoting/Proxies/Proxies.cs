// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Proxies
// Classes: 4
// Methods: 33

namespace ThirdParty.DotNet.System.Runtime.Remoting.Proxies
{
    public class ProxyAttribute : Attribute
    {
        // ── Methods ──
        public void CreateInstance(){} // RVA: 0x6759FA0
        public void CreateProxy(){} // RVA: 0x675A0D0
        public void GetPropertiesForNewContext(){} // RVA: 0xB43310
        public void IsContextOK(){} // RVA: 0xC2E4C0
    }

    public class RealProxy : Object
    {
        public object class_to_proxy;
        public object _targetContext;
        public object _server;
        public object _targetDomainId;
        public object _targetUri;
        public object _objectIdentity;
        public object _objTP;
        public object _stubData;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x675AC80
        public void InternalGetProxyType(){} // RVA: 0x675ADD0
        public void GetProxiedType(){} // RVA: 0x675ADE0
        public void GetObjectData(){} // RVA: 0x675AEA0
        public void get_ObjectIdentity(){} // RVA: 0xD05CA0
        public void set_ObjectIdentity(){} // RVA: 0xD09D70
        public void Invoke(){} // RVA: 0x87C540
        public void PrivateInvoke(){} // RVA: 0x675AF10
        public void InternalGetTransparentProxy(){} // RVA: 0x675B880
        public void GetTransparentProxy(){} // RVA: 0x675B890
        public void AttachServer(){} // RVA: 0xB70100
        public void SetTargetDomain(){} // RVA: 0x13233D0
        public void GetAppDomainTarget(){} // RVA: 0x675BA30
        public void ProcessResponse(){} // RVA: 0x675BBB0
    }

    public class RemotingProxy : RealProxy
    {
        public object _cache_GetTypeMethod;
        public object _cache_GetHashCodeMethod;
        public object _sink;
        public object _hasEnvoySink;
        public object _ctorCall;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x675C390
        public void Invoke(){} // RVA: 0x675C440
        public void AttachIdentity(){} // RVA: 0x675C870
        public void ActivateRemoteObject(){} // RVA: 0x675CDE0
        public void get_TypeName(){} // RVA: 0x675CED0
        public void CanCastTo(){} // RVA: 0x675D000
        public void Finalize(){} // RVA: 0x675D230
        public void .cctor(){} // RVA: 0x675D300
    }

    public class TransparentProxy : Object
    {
        public object _rp;
        public object _class;
        public object _custom_type_info;

        // ── Methods ──
        public void GetProxyType(){} // RVA: 0x675A130
        public void get_IsContextBoundObject(){} // RVA: 0x675A210
        public void get_TargetContext(){} // RVA: 0x13F9400
        public void InCurrentContext(){} // RVA: 0x675A2F0
        public void LoadRemoteFieldNew(){} // RVA: 0x675A430
        public void StoreRemoteField(){} // RVA: 0x675A800
        public void .ctor(){} // RVA: 0xB43310
    }

}