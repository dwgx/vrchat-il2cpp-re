// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Contexts
// Classes: 14
// Methods: 62

namespace ThirdParty.DotNet.System.Runtime.Remoting.Contexts
{
    public class Context : Object
    {
        public object domain_id;
        public object context_id;
        public object static_data;
        public object data;
        public object local_slots;
        public object default_server_context_sink;
        public object server_context_sink_chain;
        public object client_context_sink_chain;
        public object context_properties;
        public object global_count;
        public object _localDataStore;
        public object _localDataStoreMgr;
        public object global_dynamic_properties;
        public object context_dynamic_properties;
        public object callback_object;

        // ── Methods ──
        public void RegisterContext(){} // RVA: 0x675F960
        public void ReleaseContext(){} // RVA: 0x675F970
        public void .ctor(){} // RVA: 0x675F980
        public void Finalize(){} // RVA: 0x675F9E0
        public void get_DefaultContext(){} // RVA: 0x675FA50
        public void get_ContextID(){} // RVA: 0x116A650
        public void get_ContextProperties(){} // RVA: 0x675FA90
        public void get_IsDefaultContext(){} // RVA: 0x675FB00
        public void get_NeedsContextSink(){} // RVA: 0x675FB10
        public void RegisterDynamicProperty(){} // RVA: 0x675FC00
        public void UnregisterDynamicProperty(){} // RVA: 0x675FE10
        public void GetDynamicPropertyCollection(){} // RVA: 0x6760020
        public void NotifyGlobalDynamicSinks(){} // RVA: 0x67601E0
        public void get_HasGlobalDynamicSinks(){} // RVA: 0x6760310
        public void NotifyDynamicSinks(){} // RVA: 0x67603C0
        public void get_HasDynamicSinks(){} // RVA: 0x6760460
        public void get_HasExitSinks(){} // RVA: 0x67604B0
        public void GetProperty(){} // RVA: 0x6760580
        public void SetProperty(){} // RVA: 0x6760740
        public void Freeze(){} // RVA: 0x6760930
        public void ToString(){} // RVA: 0x6760B30
        public void GetServerContextSinkChain(){} // RVA: 0x6760B80
        public void GetClientContextSinkChain(){} // RVA: 0x6760E10
        public void CreateServerObjectSinkChain(){} // RVA: 0x6761090
        public void CreateEnvoySink(){} // RVA: 0x6761350
        public void SwitchToContext(){} // RVA: 0x6761540
        public void CreateNewContext(){} // RVA: 0x6761550
        public void DoCallBack(){} // RVA: 0x67615D0
        public void get_MyLocalStore(){} // RVA: 0x6761730
        public void AllocateDataSlot(){} // RVA: 0x6761960
        public void AllocateNamedDataSlot(){} // RVA: 0x67619D0
        public void FreeNamedDataSlot(){} // RVA: 0x6761A40
        public void GetNamedDataSlot(){} // RVA: 0x6761AB0
        public void GetData(){} // RVA: 0x6761B20
        public void SetData(){} // RVA: 0x6761C90
        public void .cctor(){} // RVA: 0x6761D10
    }

    public class ContextCallbackObject : ContextBoundObject
    {
        // ── Methods ──
        public void DoCallBack(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CrossContextChannel : Object
    {
        // ── Methods ──
        public void SyncProcessMessage(){} // RVA: 0x67629E0
        public void AsyncProcessMessage(){} // RVA: 0x6762D80
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CrossContextDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBA0FE0
        public void Invoke(){} // RVA: 0xBA10B0
    }

    public class DynamicPropertyCollection : Object
    {
        public object _properties;

        // ── Methods ──
        public void get_HasProperties(){} // RVA: 0x6761DE0
        public void RegisterDynamicProperty(){} // RVA: 0x6761E10
        public void UnregisterDynamicProperty(){} // RVA: 0x67621A0
        public void NotifyMessage(){} // RVA: 0x6762360
        public void FindProperty(){} // RVA: 0x67627D0
        public void .ctor(){} // RVA: 0x6762940
    }

    public class IContextAttribute
    {
        // ── Methods ──
        public void GetPropertiesForNewContext(){} // RVA: 0x894320
        public void IsContextOK(){} // RVA: 0x87D3C0
    }

    public class IContextProperty
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x87C0A0
        public void Freeze(){} // RVA: 0x894320
        public void IsNewContextOK(){} // RVA: 0x87D350
    }

    public class IContributeClientContextSink
    {
        // ── Methods ──
        public void GetClientContextSink(){} // RVA: 0x87C540
    }

    public class IContributeDynamicSink
    {
        // ── Methods ──
        public void GetDynamicSink(){} // RVA: 0x87C0A0
    }

    public class IContributeEnvoySink
    {
        // ── Methods ──
        public void GetEnvoySink(){} // RVA: 0x87C5F0
    }

    public class IContributeObjectSink
    {
        // ── Methods ──
        public void GetObjectSink(){} // RVA: 0x87C5F0
    }

    public class IContributeServerContextSink
    {
        // ── Methods ──
        public void GetServerContextSink(){} // RVA: 0x87C540
    }

    public class IDynamicMessageSink
    {
        // ── Methods ──
        public void ProcessMessageFinish(){} // RVA: 0x899F80
        public void ProcessMessageStart(){} // RVA: 0x899F80
    }

    public class IDynamicProperty
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x87C0A0
    }

}