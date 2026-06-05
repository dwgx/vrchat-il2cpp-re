// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.XR.Management
// Classes: 6
// Methods: 67

namespace ThirdParty.Unity.UnityEngine.XR.Management
{
    public class XRConfigurationDataAttribute
    {
        // ── Methods ──
        public void get_displayName(){} // RVA: 0x7FFAF2DA8380
        public void set_displayName(){} // RVA: 0x7FFAF2D8EE30
        public void get_buildSettingsKey(){} // RVA: 0x7FFAF2D907C0
        public void set_buildSettingsKey(){} // RVA: 0x7FFAF2DF3E80
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0 | overloaded x2
    }

    public class XRGeneralSettings
    {
        // ── Methods ──
        public void get_Manager(){} // RVA: 0x7FFAF2D907C0
        public void set_Manager(){} // RVA: 0x7FFAF2DF3E80
        public void get_Instance(){} // RVA: 0x7FFAF9AFAC90
        public void get_AssignedSettings(){} // RVA: 0x7FFAF2D907C0
        public void get_InitManagerOnStart(){} // RVA: 0x7FFAF2E7B9D0
        public void Awake(){} // RVA: 0x7FFAF9AFACF0
        public void Quit(){} // RVA: 0x7FFAF9AFAED0
        public void Start(){} // RVA: 0x7FFAF9AFB010
        public void OnDestroy(){} // RVA: 0x7FFAF9AFB020
        public void AttemptInitializeXRSDKOnLoad(){} // RVA: 0x7FFAF9AFB030
        public void AttemptStartXRSDKOnBeforeSplashScreen(){} // RVA: 0x7FFAF9AFB170
        public void InitXRSDK(){} // RVA: 0x7FFAF9AFB2B0
        public void StartXRSDK(){} // RVA: 0x7FFAF9AFB620
        public void StopXRSDK(){} // RVA: 0x7FFAF9AFB7B0
        public void DeInitXRSDK(){} // RVA: 0x7FFAF9AFB940
        public void .ctor(){} // RVA: 0x7FFAF9AFBB30
        public void .cctor(){} // RVA: 0x7FFAF9AFBB40
    }

    public class XRLoader
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAF2E72850
        public void Start(){} // RVA: 0x7FFAF2E72850
        public void Stop(){} // RVA: 0x7FFAF2E72850
        public void Deinitialize(){} // RVA: 0x7FFAF2E72850
        public void GetLoadedSubsystem(){} // RVA: 0x7FFAF2D33FA0
        public void GetSupportedGraphicsDeviceTypes(){} // RVA: 0x7FFAF9AFBC60
        public void .ctor(){} // RVA: 0x7FFAF2FEBFB0
    }

    public class XRLoaderHelper
    {
        // ── Methods ──
        public void GetLoadedSubsystem(){} // RVA: 0x7FFAF2D33FA0
        public void StartSubsystem(){} // RVA: 0x7FFAF2AD4A50
        public void StopSubsystem(){} // RVA: 0x7FFAF2AD4A50
        public void DestroySubsystem(){} // RVA: 0x7FFAF2AD4A50
        public void CreateSubsystem(){} // RVA: 0x7FFAF2ADDC60
        public void CreateIntegratedSubsystem(){} // RVA: 0x7FFAF2ADDC60
        public void CreateStandaloneSubsystem(){} // RVA: 0x7FFAF2ADDC60
        public void Deinitialize(){} // RVA: 0x7FFAF9AFBCC0
        public void .ctor(){} // RVA: 0x7FFAF9AFBD10
    }

    public class XRManagementAnalytics
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAF9AFBDE0
    }

    public class XRManagerSettings
    {
        // ── Methods ──
        public void get_automaticLoading(){} // RVA: 0x7FFAF4648340
        public void set_automaticLoading(){} // RVA: 0x7FFAF4648210
        public void get_automaticRunning(){} // RVA: 0x7FFAF31690C0
        public void set_automaticRunning(){} // RVA: 0x7FFAF4648350
        public void get_loaders(){} // RVA: 0x7FFAF2DBB0C0
        public void get_activeLoaders(){} // RVA: 0x7FFAF2DBB0C0
        public void get_isInitializationComplete(){} // RVA: 0x7FFAF2DA84E0
        public void get_activeLoader(){} // RVA: 0x7FFAF30E74D0
        public void set_activeLoader(){} // RVA: 0x7FFAF2DBB890
        public void ActiveLoaderAs(){} // RVA: 0x7FFAF2D33FA0
        public void InitializeLoaderSync(){} // RVA: 0x7FFAF9AFBE20
        public void InitializeLoader(){} // RVA: 0x7FFAF9AFC150
        public void TryAddLoader(){} // RVA: 0x7FFAF9AFC1F0
        public void TryRemoveLoader(){} // RVA: 0x7FFAF9AFC420
        public void TrySetLoaders(){} // RVA: 0x7FFAF9AFC4C0
        public void Awake(){} // RVA: 0x7FFAF9AFC6D0
        public void CheckGraphicsAPICompatibility(){} // RVA: 0x7FFAF9AFC890
        public void StartSubsystems(){} // RVA: 0x7FFAF9AFCAB0
        public void StopSubsystems(){} // RVA: 0x7FFAF9AFCC00
        public void DeinitializeLoader(){} // RVA: 0x7FFAF9AFCD50
        public void Start(){} // RVA: 0x7FFAF9AFCEB0
        public void OnDisable(){} // RVA: 0x7FFAF9AFCED0
        public void OnDestroy(){} // RVA: 0x7FFAF9AFCEF0
        public void get_currentLoaders(){} // RVA: 0x7FFAF2DBB0C0
        public void set_currentLoaders(){} // RVA: 0x7FFAF2DBB0D0
        public void get_registeredLoaders(){} // RVA: 0x7FFAF2DBB130
        public void .ctor(){} // RVA: 0x7FFAF9AFCF00
    }

}