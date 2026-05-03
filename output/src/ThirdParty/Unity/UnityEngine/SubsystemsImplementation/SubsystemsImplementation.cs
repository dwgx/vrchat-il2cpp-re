// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.SubsystemsImplementation
// Classes: 4
// Methods: 22

namespace ThirdParty.Unity.UnityEngine.SubsystemsImplementation
{
    public class SubsystemDescriptorStore : Object
    {
        // ── Methods ──
        public void InitializeManagedDescriptor(){} // RVA: 0x7FFE87D9ADB0
        public void ClearManagedDescriptors(){} // RVA: 0x7FFE87D9AE90
        public void ReportSingleSubsystemAnalytics(){} // RVA: 0x7FFE87D9B070
        public void GetSubsystemDescriptors(){} // RVA: 0x7FFE80E46070
        public void AddDescriptorSubset(){} // RVA: 0x7FFE80E462E0
        public void RegisterDescriptor(){} // RVA: 0x7FFE810A1420
        public void RegisterDeprecatedDescriptor(){} // RVA: 0x7FFE87D9B0C0
        public void .cctor(){} // RVA: 0x7FFE87D9B140
    }

    public class SubsystemDescriptorWithProvider : Object
    {
        public string _id; // 0x10

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFE81116380
        public void CreateImpl(){} // RVA: 0x7FFE80E2E2E0
        public void UnityEngine.ISubsystemDescriptor.Create(){} // RVA: 0x7FFE8725AEB0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SubsystemProvider : Object
    {
    }

    public class SubsystemWithProvider : Object
    {
        public bool _running; // 0x10
        public UnityEngine.SubsystemsImplementation.SubsystemProvider _providerBase; // 0x18

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE87D9B390
        public void OnStart(){} // RVA: 0x7FFE80E45FE0
        public void Stop(){} // RVA: 0x7FFE87D9B3D0
        public void OnStop(){} // RVA: 0x7FFE80E45FE0
        public void Destroy(){} // RVA: 0x7FFE87D9B410
        public void OnDestroy(){} // RVA: 0x7FFE80E45FE0
        public void get_running(){} // RVA: 0x7FFE811C55E0
        public void set_running(){} // RVA: 0x7FFE811C55F0
        public void get_providerBase(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}