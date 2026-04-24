// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Contexts
// Classes: 1
// Methods: 36

namespace ThirdParty.DotNet.System.Runtime.Remoting.Contexts
{
    public class Context : Object
    {
        public int DefaultContext; // 0x10
        public int ContextID; // 0x14
        public object ContextProperties; // 0x18
        public object IsDefaultContext; // 0x20
        public object[] NeedsContextSink;
        public _HasPrivateKey.anizationSid HasGlobalDynamicSinks; // 0x8
        public _HasPrivateKey.anizationSid HasDynamicSinks; // 0x28
        public _HasPrivateKey.anizationSid HasExitSinks; // 0x30
        public URA.woDigitYearMax<CS1SHA512SignatureDescription._HWND> MyLocalStore; // 0x38
        public int global_count; // 0x10
        public ce _localDataStore; // 0x40
        public D_MNd _localDataStoreMgr; // 0x18
        public CS1SHA512SignatureDescription.CRYPT_DELETEKEYSET global_dynamic_properties; // 0x20
        public CS1SHA512SignatureDescription.CRYPT_DELETEKEYSET context_dynamic_properties; // 0x48
        public CS1SHA512SignatureDescription.TABLE callback_object; // 0x50

        // ── Methods ──
        public void RegisterContext(){} // RVA: 0x7FFD5389E240
        public void ReleaseContext(){} // RVA: 0x7FFD5389E250
        public void .ctor(){} // RVA: 0x7FFD5389E260
        public void Finalize(){} // RVA: 0x7FFD5389E2C0
        public void get_DefaultContext(){} // RVA: 0x7FFD5389E330
        public void get_ContextID(){} // RVA: 0x7FFD4E7F5A20
        public void get_ContextProperties(){} // RVA: 0x7FFD5389E370
        public void get_IsDefaultContext(){} // RVA: 0x7FFD5389E3E0
        public void get_NeedsContextSink(){} // RVA: 0x7FFD5389E3F0
        public void RegisterDynamicProperty(){} // RVA: 0x7FFD5389E4E0
        public void UnregisterDynamicProperty(){} // RVA: 0x7FFD5389E6F0
        public void GetDynamicPropertyCollection(){} // RVA: 0x7FFD5389E900
        public void NotifyGlobalDynamicSinks(){} // RVA: 0x7FFD5389EAC0
        public void get_HasGlobalDynamicSinks(){} // RVA: 0x7FFD5389EBF0
        public void NotifyDynamicSinks(){} // RVA: 0x7FFD5389ECA0
        public void get_HasDynamicSinks(){} // RVA: 0x7FFD5389ED40
        public void get_HasExitSinks(){} // RVA: 0x7FFD5389ED90
        public void GetProperty(){} // RVA: 0x7FFD5389EE60
        public void SetProperty(){} // RVA: 0x7FFD5389F020
        public void Freeze(){} // RVA: 0x7FFD5389F210
        public void ToString(){} // RVA: 0x7FFD5389F410
        public void GetServerContextSinkChain(){} // RVA: 0x7FFD5389F460
        public void GetClientContextSinkChain(){} // RVA: 0x7FFD5389F6C0
        public void CreateServerObjectSinkChain(){} // RVA: 0x7FFD5389F930
        public void CreateEnvoySink(){} // RVA: 0x7FFD5389FBD0
        public void SwitchToContext(){} // RVA: 0x7FFD5389FDB0
        public void CreateNewContext(){} // RVA: 0x7FFD5389FDC0
        public void DoCallBack(){} // RVA: 0x7FFD5389FE40
        public void get_MyLocalStore(){} // RVA: 0x7FFD5389FFE0
        public void AllocateDataSlot(){} // RVA: 0x7FFD538A0240
        public void AllocateNamedDataSlot(){} // RVA: 0x7FFD538A02B0
        public void FreeNamedDataSlot(){} // RVA: 0x7FFD538A0320
        public void GetNamedDataSlot(){} // RVA: 0x7FFD538A0390
        public void GetData(){} // RVA: 0x7FFD538A0400
        public void SetData(){} // RVA: 0x7FFD538A0570
        public void .cctor(){} // RVA: 0x7FFD538A05F0
    }

}