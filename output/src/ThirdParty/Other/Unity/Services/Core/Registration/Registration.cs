// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core.Registration
// Classes: 1
// Methods: 39

namespace ThirdParty.Other.Unity.Services.Core.Registration
{
    public class CorePackageInitializer : Object
    {
        public Unity.Services.Core.Scheduler.Internal.ActionScheduler ActionScheduler; // 0x10
        public Unity.Services.Core.Device.InstallationId InstallationId; // 0x18
        public Unity.Services.Core.Configuration.ProjectConfiguration ProjectConfig; // 0x20
        public Unity.Services.Core.Environments.Internal.Environments Environments; // 0x28
        public Unity.Services.Core.Configuration.ExternalUserId ExternalUserId; // 0x30
        public Unity.Services.Core.Configuration.Internal.ICloudProjectId CloudProjectId; // 0x38
        public Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory DiagnosticsFactory; // 0x40
        public Unity.Services.Core.Telemetry.Internal.IMetricsFactory MetricsFactory; // 0x48
        public Unity.Services.Core.Threading.Internal.UnityThreadUtilsInternal UnityThreadUtils; // 0x50
        public Unity.Services.Core.Internal.CoreRegistry m_Registry; // 0x58
        public Unity.Services.Core.Internal.Serialization.IJsonSerializer m_Serializer; // 0x60
        public Unity.Services.Core.InitializationOptions m_CurrentInitializationOptions; // 0x68

        // ── Methods ──
        public void get_ActionScheduler(){} // RVA: 0x7FFAC2F3C380
        public void set_ActionScheduler(){} // RVA: 0x7FFAC2F22E30
        public void get_InstallationId(){} // RVA: 0x7FFAC2F247C0
        public void set_InstallationId(){} // RVA: 0x7FFAC2F87E80
        public void get_ProjectConfig(){} // RVA: 0x7FFAC2F4F0C0
        public void set_ProjectConfig(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Environments(){} // RVA: 0x7FFAC2F4F130
        public void set_Environments(){} // RVA: 0x7FFAC2F22E90
        public void get_ExternalUserId(){} // RVA: 0x7FFAC31D95E0
        public void set_ExternalUserId(){} // RVA: 0x7FFAC2F4F890
        public void get_CloudProjectId(){} // RVA: 0x7FFAC31D0140
        public void set_CloudProjectId(){} // RVA: 0x7FFAC31D0C20
        public void get_DiagnosticsFactory(){} // RVA: 0x7FFAC2F9E740
        public void set_DiagnosticsFactory(){} // RVA: 0x7FFAC2F49200
        public void get_MetricsFactory(){} // RVA: 0x7FFAC2F9C730
        public void set_MetricsFactory(){} // RVA: 0x7FFAC2F9C740
        public void get_UnityThreadUtils(){} // RVA: 0x7FFAC2FC20E0
        public void set_UnityThreadUtils(){} // RVA: 0x7FFAC30794D0
        public void InitializeOnLoad(){} // RVA: 0x7FFAC96FA000
        public void Register(){} // RVA: 0x7FFAC96FA100
        public void .ctor(){} // RVA: 0x7FFAC2FBF380
        public void Initialize(){} // RVA: 0x7FFAC96FA450
        public void InitializeInstanceAsync(){} // RVA: 0x7FFAC96FA450
        public void InitializeComponents(){} // RVA: 0x7FFAC96FA4B0
        public void HaveInitOptionsChanged(){} // RVA: 0x7FFAC96FA660
        public void FreeOptionsDependantComponents(){} // RVA: 0x7FFAC96FA720
        public void InitializeInstallationId(){} // RVA: 0x7FFAC96FA870
        public void InitializeActionScheduler(){} // RVA: 0x7FFAC96FAA30
        public void InitializeProjectConfigAsync(){} // RVA: 0x7FFAC96FAB30
        public void GenerateProjectConfigurationAsync(){} // RVA: 0x7FFAC96FAD30
        public void GetSerializedConfigOrEmptyAsync(){} // RVA: 0x7FFAC96FAF10
        public void InitializeExternalUserId(){} // RVA: 0x7FFAC96FB030
        public void InitializeEnvironments(){} // RVA: 0x7FFAC96FB2A0
        public void InitializeMetrics(){} // RVA: 0x7FFAC96FB410
        public void InitializeDiagnostics(){} // RVA: 0x7FFAC96FB560
        public void InitializeCloudProjectId(){} // RVA: 0x7FFAC96FB6B0
        public void InitializeUnityThreadUtils(){} // RVA: 0x7FFAC96FB750
        public void <InitializeComponents>g__RegisterProvidedComponents|47_0(){} // RVA: 0x7FFAC96FB7F0
        public void <InitializeComponents>g__SendFailedInitDiagnostic|47_1(){} // RVA: 0x7FFAC2F21320
    }

}