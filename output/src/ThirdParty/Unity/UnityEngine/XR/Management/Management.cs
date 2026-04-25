// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.XR.Management
// Classes: 6
// Methods: 67

namespace ThirdParty.Unity.UnityEngine.XR.Management
{
    public class XRConfigurationDataAttribute : Attribute
    {
        public string displayName; // 0x10
        public string buildSettingsKey; // 0x18

        // ── Methods ──
        public void get_displayName(){} // RVA: 0x7FFAC2F3C380
        public void set_displayName(){} // RVA: 0x7FFAC2F22E30
        public void get_buildSettingsKey(){} // RVA: 0x7FFAC2F247C0
        public void set_buildSettingsKey(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
    }

    public class XRGeneralSettings : ScriptableObject
    {
        public string Manager;
        public UnityEngine.XR.Management.XRGeneralSettings Instance; // 0x8
        public UnityEngine.XR.Management.XRManagerSettings AssignedSettings; // 0x18
        public bool InitManagerOnStart; // 0x20
        public UnityEngine.XR.Management.XRManagerSettings m_XRManager; // 0x28
        public bool m_ProviderIntialized; // 0x30
        public bool m_ProviderStarted; // 0x31

        // ── Methods ──
        public void get_Manager(){} // RVA: 0x7FFAC2F247C0
        public void set_Manager(){} // RVA: 0x7FFAC2F87E80
        public void get_Instance(){} // RVA: 0x7FFAC97E35E0
        public void get_AssignedSettings(){} // RVA: 0x7FFAC2F247C0
        public void get_InitManagerOnStart(){} // RVA: 0x7FFAC300F9D0
        public void Awake(){} // RVA: 0x7FFAC97E3640
        public void Quit(){} // RVA: 0x7FFAC97E3820
        public void Start(){} // RVA: 0x7FFAC97E3960
        public void OnDestroy(){} // RVA: 0x7FFAC97E3970
        public void AttemptInitializeXRSDKOnLoad(){} // RVA: 0x7FFAC97E3980
        public void AttemptStartXRSDKOnBeforeSplashScreen(){} // RVA: 0x7FFAC97E3AC0
        public void InitXRSDK(){} // RVA: 0x7FFAC97E3C00
        public void StartXRSDK(){} // RVA: 0x7FFAC97E3F70
        public void StopXRSDK(){} // RVA: 0x7FFAC97E4100
        public void DeInitXRSDK(){} // RVA: 0x7FFAC97E4290
        public void .ctor(){} // RVA: 0x7FFAC97E4480
        public void .cctor(){} // RVA: 0x7FFAC97E4490
    }

    public class XRLoader : ScriptableObject
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC3006850
        public void Start(){} // RVA: 0x7FFAC3006850
        public void Stop(){} // RVA: 0x7FFAC3006850
        public void Deinitialize(){} // RVA: 0x7FFAC3006850
        public void GetLoadedSubsystem(){} // RVA: 0x7FFAC2E8DC40
        public void GetSupportedGraphicsDeviceTypes(){} // RVA: 0x7FFAC97E45B0
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class XRLoaderHelper : XRLoader
    {
        public System.Collections.Generic.Dictionary`2<System.Type,UnityEngine.ISubsystem> m_SubsystemInstanceMap; // 0x18

        // ── Methods ──
        public void GetLoadedSubsystem(){} // RVA: 0x7FFAC2E8DC40
        public void StartSubsystem(){} // RVA: 0x7FFAC2C70980
        public void StopSubsystem(){} // RVA: 0x7FFAC2C70980
        public void DestroySubsystem(){} // RVA: 0x7FFAC2C70980
        public void CreateSubsystem(){} // RVA: 0x7FFAC2C79B30
        public void CreateIntegratedSubsystem(){} // RVA: 0x7FFAC2C79B30
        public void CreateStandaloneSubsystem(){} // RVA: 0x7FFAC2C79B30
        public void Deinitialize(){} // RVA: 0x7FFAC97E4610
        public void .ctor(){} // RVA: 0x7FFAC97E4660
    }

    public class XRManagementAnalytics : Object
    {
        public int kMaxEventsPerHour;
        public int kMaxNumberOfElements;
        public string kVendorKey;
        public string kEventBuild;
        public bool s_Initialized;

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC97E4730
    }

    public class XRManagerSettings : ScriptableObject
    {
        public bool automaticLoading; // 0x18
        public bool automaticRunning; // 0x19
        public bool loaders; // 0x1A
        public bool activeLoaders; // 0x1B
        public System.Collections.Generic.List`1<UnityEngine.XR.Management.XRLoader> isInitializationComplete; // 0x20
        public System.Collections.Generic.HashSet`1<UnityEngine.XR.Management.XRLoader> activeLoader; // 0x28
        public UnityEngine.XR.Management.XRLoader currentLoaders; // 0x30

        // ── Methods ──
        public void get_automaticLoading(){} // RVA: 0x7FFAC45FA190
        public void set_automaticLoading(){} // RVA: 0x7FFAC45F9AE0
        public void get_automaticRunning(){} // RVA: 0x7FFAC3228BF0
        public void set_automaticRunning(){} // RVA: 0x7FFAC45FACF0
        public void get_loaders(){} // RVA: 0x7FFAC2F4F0C0
        public void get_activeLoaders(){} // RVA: 0x7FFAC2F4F0C0
        public void get_isInitializationComplete(){} // RVA: 0x7FFAC2F3C4E0
        public void get_activeLoader(){} // RVA: 0x7FFAC31D95E0
        public void set_activeLoader(){} // RVA: 0x7FFAC2F4F890
        public void ActiveLoaderAs(){} // RVA: 0x7FFAC2E8DC40
        public void InitializeLoaderSync(){} // RVA: 0x7FFAC97E4770
        public void InitializeLoader(){} // RVA: 0x7FFAC97E4AA0
        public void TryAddLoader(){} // RVA: 0x7FFAC97E4B40
        public void TryRemoveLoader(){} // RVA: 0x7FFAC97E4D70
        public void TrySetLoaders(){} // RVA: 0x7FFAC97E4E10
        public void Awake(){} // RVA: 0x7FFAC97E5020
        public void CheckGraphicsAPICompatibility(){} // RVA: 0x7FFAC97E51E0
        public void StartSubsystems(){} // RVA: 0x7FFAC97E5400
        public void StopSubsystems(){} // RVA: 0x7FFAC97E5550
        public void DeinitializeLoader(){} // RVA: 0x7FFAC97E56A0
        public void Start(){} // RVA: 0x7FFAC97E5800
        public void OnDisable(){} // RVA: 0x7FFAC97E5820
        public void OnDestroy(){} // RVA: 0x7FFAC97E5840
        public void get_currentLoaders(){} // RVA: 0x7FFAC2F4F0C0
        public void set_currentLoaders(){} // RVA: 0x7FFAC2F4F0D0
        public void get_registeredLoaders(){} // RVA: 0x7FFAC2F4F130
        public void .ctor(){} // RVA: 0x7FFAC97E5850
    }

}