// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Contexts
// Classes: 14
// Methods: 62

namespace ThirdParty.DotNet.System.Runtime.Remoting.Contexts
{
    public class Context
    {
        // ── Methods ──
        public void RegisterContext(){} // RVA: 0x5CE6C50
        public void ReleaseContext(){} // RVA: 0x5CE6C60
        public void .ctor(){} // RVA: 0x5CE6C70
        public void Finalize(){} // RVA: 0x5CE6CD0
        public void get_DefaultContext(){} // RVA: 0x5CE6D40
        public void get_ContextID(){} // RVA: 0x8ABED0
        public void get_ContextProperties(){} // RVA: 0x5CE6D80
        public void get_IsDefaultContext(){} // RVA: 0x5CE6DF0
        public void get_NeedsContextSink(){} // RVA: 0x5CE6E00
        public void RegisterDynamicProperty(){} // RVA: 0x5CE6EF0
        public void UnregisterDynamicProperty(){} // RVA: 0x5CE7100
        public void GetDynamicPropertyCollection(){} // RVA: 0x5CE7310
        public void NotifyGlobalDynamicSinks(){} // RVA: 0x5CE74D0
        public void get_HasGlobalDynamicSinks(){} // RVA: 0x5CE7600
        public void NotifyDynamicSinks(){} // RVA: 0x5CE76B0
        public void get_HasDynamicSinks(){} // RVA: 0x5CE7750
        public void get_HasExitSinks(){} // RVA: 0x5CE77A0
        public void GetProperty(){} // RVA: 0x5CE7870
        public void SetProperty(){} // RVA: 0x5CE7A30
        public void Freeze(){} // RVA: 0x5CE7C20
        public void ToString(){} // RVA: 0x5CE7E20
        public void GetServerContextSinkChain(){} // RVA: 0x5CE7E70
        public void GetClientContextSinkChain(){} // RVA: 0x5CE80D0
        public void CreateServerObjectSinkChain(){} // RVA: 0x5CE8340
        public void CreateEnvoySink(){} // RVA: 0x5CE85E0
        public void SwitchToContext(){} // RVA: 0x5CE87C0
        public void CreateNewContext(){} // RVA: 0x5CE87D0
        public void DoCallBack(){} // RVA: 0x5CE8850
        public void get_MyLocalStore(){} // RVA: 0x5CE89F0
        public void AllocateDataSlot(){} // RVA: 0x5CE8C50
        public void AllocateNamedDataSlot(){} // RVA: 0x5CE8CC0
        public void FreeNamedDataSlot(){} // RVA: 0x5CE8D30
        public void GetNamedDataSlot(){} // RVA: 0x5CE8DA0
        public void GetData(){} // RVA: 0x5CE8E10
        public void SetData(){} // RVA: 0x5CE8F80
        public void .cctor(){} // RVA: 0x5CE9000
    }

    public class ContextCallbackObject
    {
        // ── Methods ──
        public void DoCallBack(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CrossContextChannel
    {
        // ── Methods ──
        public void SyncProcessMessage(){} // RVA: 0x5CE9D70
        public void AsyncProcessMessage(){} // RVA: 0x5CEA110
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CrossContextDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x33B980
        public void Invoke(){} // RVA: 0x33BA50
    }

    public class DynamicPropertyCollection
    {
        // ── Methods ──
        public void get_HasProperties(){} // RVA: 0x5CE90D0
        public void RegisterDynamicProperty(){} // RVA: 0x5CE9100
        public void UnregisterDynamicProperty(){} // RVA: 0x5CE94D0
        public void NotifyMessage(){} // RVA: 0x5CE96D0
        public void FindProperty(){} // RVA: 0x5CE9B70
        public void .ctor(){} // RVA: 0x5CE9CD0
    }

    public class IContextAttribute
    {
        // ── Methods ──
        public void GetPropertiesForNewContext(){} // RVA: 0x24B10
        public void IsContextOK(){} // RVA: 0x11120
    }

    public class IContextProperty
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0xCD60
        public void Freeze(){} // RVA: 0x24B10
        public void IsNewContextOK(){} // RVA: 0xDE40
    }

    public class IContributeClientContextSink
    {
        // ── Methods ──
        public void GetClientContextSink(){} // RVA: 0xCE10
    }

    public class IContributeDynamicSink
    {
        // ── Methods ──
        public void GetDynamicSink(){} // RVA: 0xCD60
    }

    public class IContributeEnvoySink
    {
        // ── Methods ──
        public void GetEnvoySink(){} // RVA: 0x1E6A0
    }

    public class IContributeObjectSink
    {
        // ── Methods ──
        public void GetObjectSink(){} // RVA: 0x1E6A0
    }

    public class IContributeServerContextSink
    {
        // ── Methods ──
        public void GetServerContextSink(){} // RVA: 0xCE10
    }

    public class IDynamicMessageSink
    {
        // ── Methods ──
        public void ProcessMessageFinish(){} // RVA: 0x2A6B0
        public void ProcessMessageStart(){} // RVA: 0x2A6B0
    }

    public class IDynamicProperty
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0xCD60
    }

}