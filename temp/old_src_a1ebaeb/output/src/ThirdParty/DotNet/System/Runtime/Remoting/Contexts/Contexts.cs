// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Contexts
// Classes: 1
// Methods: 36

namespace ThirdParty.DotNet.System.Runtime.Remoting.Contexts
{
    public class Context : Object
    {
        public object static_data; // 0x31A67030
        public object default_server_context_sink; // 0x31A67030
        public object context_properties; // 0x31A67030
        public object _localDataStoreMgr; // 0x31A67030
        public object callback_object; // 0x31A67030
        public object DefaultContext; // 0x17000415
        public object ContextID; // 0x17000416
        public object ContextProperties; // 0x17000417
        public object IsDefaultContext; // 0x17000418
        public object NeedsContextSink; // 0x17000419

        // ── Original Methods ──
        public void RegisterContext(){} // RVA: 0x7ffaade9f3f0
        public void ReleaseContext(){} // RVA: 0x7ffaade9f400
        public void .ctor(){} // RVA: 0x7ffaade9f410
        public void Finalize(){} // RVA: 0x7ffaade9f470
        public void get_DefaultContext(){} // RVA: 0x7ffaade9f4e0
        public void get_ContextID(){} // RVA: 0x7ffaa8e046c0
        public void get_ContextProperties(){} // RVA: 0x7ffaade9f520
        public void get_IsDefaultContext(){} // RVA: 0x7ffaade9f590
        public void get_NeedsContextSink(){} // RVA: 0x7ffaade9f5a0
        public void RegisterDynamicProperty(){} // RVA: 0x7ffaade9f690
        public void UnregisterDynamicProperty(){} // RVA: 0x7ffaade9f8a0
        public void NotifyGlobalDynamicSinks(){} // RVA: 0x7ffaade9fc70
        public void get_HasGlobalDynamicSinks(){} // RVA: 0x7ffaade9fda0
        public void NotifyDynamicSinks(){} // RVA: 0x7ffaade9fe50
        public void get_HasDynamicSinks(){} // RVA: 0x7ffaade9fef0
        public void get_HasExitSinks(){} // RVA: 0x7ffaade9ff40
        public void Freeze(){} // RVA: 0x7ffaadea03c0
        public void ToString(){} // RVA: 0x7ffaadea05c0
        public void CreateServerObjectSinkChain(){} // RVA: 0x7ffaadea0ae0
        public void CreateEnvoySink(){} // RVA: 0x7ffaadea0d80
        public void SwitchToContext(){} // RVA: 0x7ffaadea0f60
        public void CreateNewContext(){} // RVA: 0x7ffaadea0f70
        public void get_MyLocalStore(){} // RVA: 0x7ffaadea1190
        public void AllocateDataSlot(){} // RVA: 0x7ffaadea13f0
        public void AllocateNamedDataSlot(){} // RVA: 0x7ffaadea1460
        public void FreeNamedDataSlot(){} // RVA: 0x7ffaadea14d0
        public void .cctor(){} // RVA: 0x7ffaadea17a0
        // ── Binary Analysis Named ──
        public void GetDynamicPropertyCollection(){} // RVA: 0x7ffaade9fab0
        public void GetProperty(){} // RVA: 0x7ffaadea0010
        public void SetProperty(){} // RVA: 0x7ffaadea01d0
        public void GetServerContextSinkChain(){} // RVA: 0x7ffaadea0610
        public void GetClientContextSinkChain(){} // RVA: 0x7ffaadea0870
        public void DoCallBack(){} // RVA: 0x7ffaadea0ff0
        public void GetNamedDataSlot(){} // RVA: 0x7ffaadea1540
        public void GetData(){} // RVA: 0x7ffaadea15b0
        public void SetData(){} // RVA: 0x7ffaadea1720
    }

}