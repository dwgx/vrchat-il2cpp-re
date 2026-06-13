// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.XR.Management
// Classes: 6
// Methods: 67

namespace ThirdParty.Unity.UnityEngine.XR.Management
{
    public class XRConfigurationDataAttribute
    {
        public string <displayName>k__BackingField; // 0x10
        public string <buildSettingsKey>k__BackingField; // 0x18

        // ── Methods ──
        public void get_displayName(){} // RVA: 0x2F8380
        public void set_displayName(){} // RVA: 0x2DEE30
        public void get_buildSettingsKey(){} // RVA: 0x2E07C0
        public void set_buildSettingsKey(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x2
    }

    public class XRGeneralSettings
    {
        public string k_SettingsKey;
        public UnityEngine.XR.Management.XRGeneralSettings s_RuntimeSettingsInstance; // 0x8
        public UnityEngine.XR.Management.XRManagerSettings m_LoaderManagerInstance; // 0x18
        public bool m_InitManagerOnStart; // 0x20

        // ── Methods ──
        public void get_Manager(){} // RVA: 0x2E07C0
        public void set_Manager(){} // RVA: 0x343E80
        public void get_Instance(){} // RVA: 0x704AC90
        public void get_AssignedSettings(){} // RVA: 0x2E07C0
        public void get_InitManagerOnStart(){} // RVA: 0x3CB9D0
        public void Awake(){} // RVA: 0x704ACF0
        public void Quit(){} // RVA: 0x704AED0
        public void Start(){} // RVA: 0x704B010
        public void OnDestroy(){} // RVA: 0x704B020
        public void AttemptInitializeXRSDKOnLoad(){} // RVA: 0x704B030
        public void AttemptStartXRSDKOnBeforeSplashScreen(){} // RVA: 0x704B170
        public void InitXRSDK(){} // RVA: 0x704B2B0
        public void StartXRSDK(){} // RVA: 0x704B620
        public void StopXRSDK(){} // RVA: 0x704B7B0
        public void DeInitXRSDK(){} // RVA: 0x704B940
        public void .ctor(){} // RVA: 0x704BB30
        public void .cctor(){} // RVA: 0x704BB40
    }

    public class XRLoader
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x3C2850
        public void Start(){} // RVA: 0x3C2850
        public void Stop(){} // RVA: 0x3C2850
        public void Deinitialize(){} // RVA: 0x3C2850
        public void GetLoadedSubsystem(){} // RVA: 0x283FA0
        public void GetSupportedGraphicsDeviceTypes(){} // RVA: 0x704BC60
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class XRLoaderHelper
    {
        // ── Methods ──
        public void GetLoadedSubsystem(){} // RVA: 0x283FA0
        public void StartSubsystem(){} // RVA: 0x24A50
        public void StopSubsystem(){} // RVA: 0x24A50
        public void DestroySubsystem(){} // RVA: 0x24A50
        public void CreateSubsystem(){} // RVA: 0x2DC60
        public void CreateIntegratedSubsystem(){} // RVA: 0x2DC60
        public void CreateStandaloneSubsystem(){} // RVA: 0x2DC60
        public void Deinitialize(){} // RVA: 0x704BCC0
        public void .ctor(){} // RVA: 0x704BD10
    }

    public class XRManagementAnalytics
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x704BDE0
    }

    public class XRManagerSettings
    {
        public bool m_InitializationComplete; // 0x18
        public bool m_RequiresSettingsUpdate; // 0x19
        public bool m_AutomaticLoading; // 0x1A
        public bool m_AutomaticRunning; // 0x1B
        public System.Collections.Generic.List`1<UnityEngine.XR.Management.XRLoader> m_Loaders; // 0x20
        public System.Collections.Generic.HashSet`1<UnityEngine.XR.Management.XRLoader> m_RegisteredLoaders; // 0x28
        public UnityEngine.XR.Management.XRLoader <activeLoader>k__BackingField; // 0x30

        // ── Methods ──
        public void get_automaticLoading(){} // RVA: 0x1B98340
        public void set_automaticLoading(){} // RVA: 0x1B98210
        public void get_automaticRunning(){} // RVA: 0x6B90C0
        public void set_automaticRunning(){} // RVA: 0x1B98350
        public void get_loaders(){} // RVA: 0x30B0C0
        public void get_activeLoaders(){} // RVA: 0x30B0C0
        public void get_isInitializationComplete(){} // RVA: 0x2F84E0
        public void get_activeLoader(){} // RVA: 0x6374D0
        public void set_activeLoader(){} // RVA: 0x30B890
        public void ActiveLoaderAs(){} // RVA: 0x283FA0
        public void InitializeLoaderSync(){} // RVA: 0x704BE20
        public void InitializeLoader(){} // RVA: 0x704C150
        public void TryAddLoader(){} // RVA: 0x704C1F0
        public void TryRemoveLoader(){} // RVA: 0x704C420
        public void TrySetLoaders(){} // RVA: 0x704C4C0
        public void Awake(){} // RVA: 0x704C6D0
        public void CheckGraphicsAPICompatibility(){} // RVA: 0x704C890
        public void StartSubsystems(){} // RVA: 0x704CAB0
        public void StopSubsystems(){} // RVA: 0x704CC00
        public void DeinitializeLoader(){} // RVA: 0x704CD50
        public void Start(){} // RVA: 0x704CEB0
        public void OnDisable(){} // RVA: 0x704CED0
        public void OnDestroy(){} // RVA: 0x704CEF0
        public void get_currentLoaders(){} // RVA: 0x30B0C0
        public void set_currentLoaders(){} // RVA: 0x30B0D0
        public void get_registeredLoaders(){} // RVA: 0x30B130
        public void .ctor(){} // RVA: 0x704CF00
    }

}