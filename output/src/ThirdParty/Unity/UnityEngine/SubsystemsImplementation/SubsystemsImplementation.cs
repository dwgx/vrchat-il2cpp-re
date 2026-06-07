// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.SubsystemsImplementation
// Classes: 4
// Methods: 22

namespace ThirdParty.Unity.UnityEngine.SubsystemsImplementation
{
    public class SubsystemDescriptorStore
    {
        // ── Methods ──
        public void InitializeManagedDescriptor(){} // RVA: 0x725AC10
        public void ClearManagedDescriptors(){} // RVA: 0x725ACF0
        public void ReportSingleSubsystemAnalytics(){} // RVA: 0x725AED0
        public void GetSubsystemDescriptors(){} // RVA: 0x24AE0
        public void AddDescriptorSubset(){} // RVA: 0x24D50
        public void RegisterDescriptor(){} // RVA: 0x283FA0
        public void RegisterDeprecatedDescriptor(){} // RVA: 0x725AF20
        public void .cctor(){} // RVA: 0x725AFA0
    }

    public class SubsystemDescriptorWithProvider
    {
        // ── Methods ──
        public void get_id(){} // RVA: 0x2F8380
        public void CreateImpl(){} // RVA: 0xCD60
        public void UnityEngine.ISubsystemDescriptor.Create(){} // RVA: 0x671BFB0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SubsystemProvider
    {
    }

    public class SubsystemWithProvider
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x725B1F0
        public void OnStart(){} // RVA: 0x24A50
        public void Stop(){} // RVA: 0x725B230
        public void OnStop(){} // RVA: 0x24A50
        public void Destroy(){} // RVA: 0x725B270
        public void OnDestroy(){} // RVA: 0x24A50
        public void get_running(){} // RVA: 0x3A75E0
        public void set_running(){} // RVA: 0x3A75F0
        public void get_providerBase(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0x2DD310
    }

}