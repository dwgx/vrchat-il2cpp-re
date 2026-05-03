// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core.Registration
// Classes: 1
// Methods: 39

namespace ThirdParty.Other.Unity.Services.Core.Registration
{
    public class CorePackageInitializer : Object
    {
        public Unity.Services.Core.Scheduler.Internal.ActionScheduler _actionScheduler; // 0x10
        public Unity.Services.Core.Device.InstallationId _installationId; // 0x18
        public Unity.Services.Core.Configuration.ProjectConfiguration _projectConfig; // 0x20
        public Unity.Services.Core.Environments.Internal.Environments _environments; // 0x28
        public Unity.Services.Core.Configuration.ExternalUserId _externalUserId; // 0x30
        public Unity.Services.Core.Configuration.Internal.ICloudProjectId _cloudProjectId; // 0x38
        public Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory _diagnosticsFactory; // 0x40
        public Unity.Services.Core.Telemetry.Internal.IMetricsFactory _metricsFactory; // 0x48
        public Unity.Services.Core.Threading.Internal.UnityThreadUtilsInternal _unityThreadUtils; // 0x50

        // ── Methods ──
        public void get_ActionScheduler(){} // RVA: 0x7FFE81116380
        public void set_ActionScheduler(){} // RVA: 0x7FFE810FCE30
        public void get_InstallationId(){} // RVA: 0x7FFE810FE7C0
        public void set_InstallationId(){} // RVA: 0x7FFE81161E80
        public void get_ProjectConfig(){} // RVA: 0x7FFE811290C0
        public void set_ProjectConfig(){} // RVA: 0x7FFE811290D0
        public void get_Environments(){} // RVA: 0x7FFE81129130
        public void set_Environments(){} // RVA: 0x7FFE810FCE90
        public void get_ExternalUserId(){} // RVA: 0x7FFE8144E200
        public void set_ExternalUserId(){} // RVA: 0x7FFE81129890
        public void get_CloudProjectId(){} // RVA: 0x7FFE8143BA80
        public void set_CloudProjectId(){} // RVA: 0x7FFE81437330
        public void get_DiagnosticsFactory(){} // RVA: 0x7FFE81178740
        public void set_DiagnosticsFactory(){} // RVA: 0x7FFE81123200
        public void get_MetricsFactory(){} // RVA: 0x7FFE81176730
        public void set_MetricsFactory(){} // RVA: 0x7FFE81176740
        public void get_UnityThreadUtils(){} // RVA: 0x7FFE8119C0E0
        public void set_UnityThreadUtils(){} // RVA: 0x7FFE812534D0
        public void InitializeOnLoad(){} // RVA: 0x7FFE87AA2570
        public void Register(){} // RVA: 0x7FFE87AA2670
        public void .ctor(){} // RVA: 0x7FFE81199380
        public void Initialize(){} // RVA: 0x7FFE87AA29C0
        public void InitializeInstanceAsync(){} // RVA: 0x7FFE87AA29C0
        public void InitializeComponents(){} // RVA: 0x7FFE87AA2A20
        public void HaveInitOptionsChanged(){} // RVA: 0x7FFE87AA2BD0
        public void FreeOptionsDependantComponents(){} // RVA: 0x7FFE87AA2C90
        public void InitializeInstallationId(){} // RVA: 0x7FFE87AA2DE0
        public void InitializeActionScheduler(){} // RVA: 0x7FFE87AA2FA0
        public void InitializeProjectConfigAsync(){} // RVA: 0x7FFE87AA30A0
        public void GenerateProjectConfigurationAsync(){} // RVA: 0x7FFE87AA32A0
        public void GetSerializedConfigOrEmptyAsync(){} // RVA: 0x7FFE87AA3480
        public void InitializeExternalUserId(){} // RVA: 0x7FFE87AA35A0
        public void InitializeEnvironments(){} // RVA: 0x7FFE87AA3810
        public void InitializeMetrics(){} // RVA: 0x7FFE87AA3980
        public void InitializeDiagnostics(){} // RVA: 0x7FFE87AA3AD0
        public void InitializeCloudProjectId(){} // RVA: 0x7FFE87AA3C20
        public void InitializeUnityThreadUtils(){} // RVA: 0x7FFE87AA3CC0
        public void <InitializeComponents>g__RegisterProvidedComponents|47_0(){} // RVA: 0x7FFE87AA3D60
        public void <InitializeComponents>g__SendFailedInitDiagnostic|47_1(){} // RVA: 0x7FFE810FB320
    }

}