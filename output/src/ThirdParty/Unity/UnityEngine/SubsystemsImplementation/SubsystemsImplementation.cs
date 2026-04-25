// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.SubsystemsImplementation
// Classes: 4
// Methods: 22

namespace ThirdParty.Unity.UnityEngine.SubsystemsImplementation
{
    public class SubsystemDescriptorStore : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.IntegratedSubsystemDescriptor> s_IntegratedDescriptors;
        public System.Collections.Generic.List`1<UnityEngine.SubsystemsImplementation.SubsystemDescriptorWithProvider> s_StandaloneDescriptors; // 0x8
        public System.Collections.Generic.List`1<UnityEngine.SubsystemDescriptor> s_DeprecatedDescriptors; // 0x10

        // ── Methods ──
        public void InitializeManagedDescriptor(){} // RVA: 0x7FFAC99F2510
        public void ClearManagedDescriptors(){} // RVA: 0x7FFAC99F25F0
        public void ReportSingleSubsystemAnalytics(){} // RVA: 0x7FFAC99F27D0
        public void GetSubsystemDescriptors(){} // RVA: 0x7FFAC2C70A10
        public void AddDescriptorSubset(){} // RVA: 0x7FFAC2C70C80
        public void RegisterDescriptor(){} // RVA: 0x7FFAC2E8DC40
        public void RegisterDeprecatedDescriptor(){} // RVA: 0x7FFAC99F2820
        public void .cctor(){} // RVA: 0x7FFAC99F28A0
    }

    public class SubsystemDescriptorWithProvider : Object
    {
        public string id; // 0x10

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFAC2F3C380
        public void CreateImpl(){} // RVA: 0x7FFAC2C58E90
        public void UnityEngine.ISubsystemDescriptor.Create(){} // RVA: 0x7FFAC3EEA090
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SubsystemProvider : Object
    {
        public bool m_Running; // 0x10
    }

    public class SubsystemWithProvider : Object
    {
        public bool running; // 0x10
        public UnityEngine.SubsystemsImplementation.SubsystemProvider providerBase; // 0x18

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC99F2AF0
        public void OnStart(){} // RVA: 0x7FFAC2C70980
        public void Stop(){} // RVA: 0x7FFAC99F2B30
        public void OnStop(){} // RVA: 0x7FFAC2C70980
        public void Destroy(){} // RVA: 0x7FFAC99F2B70
        public void OnDestroy(){} // RVA: 0x7FFAC2C70980
        public void get_running(){} // RVA: 0x7FFAC2FEB5E0
        public void set_running(){} // RVA: 0x7FFAC2FEB5F0
        public void get_providerBase(){} // RVA: 0x7FFAC2F247C0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}