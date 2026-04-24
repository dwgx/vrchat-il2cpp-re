// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.XR.Management
// Classes: 6
// Methods: 67

namespace ThirdParty.Unity.UnityEngine.XR.Management
{
    public class XRConfigurationDataAttribute : Attribute
    {
        // ── Original Methods ──
        public void get_displayName(){} // RVA: 0x7ffaa894d380
        public void set_displayName(){} // RVA: 0x7ffaa8933e30
        public void get_buildSettingsKey(){} // RVA: 0x7ffaa89357c0
        public void set_buildSettingsKey(){} // RVA: 0x7ffaa8998e80
        public void .ctor(){} // RVA: 0x7ffaa8f15e70
        public void .ctor(){} // RVA: 0x7ffaa8f15e70
    }

    public class XRGeneralSettings : ScriptableObject
    {
        public object m_LoaderManagerInstance; // 0x337C41B0
        public object m_ProviderIntialized; // 0x337C41B0

        // ── Original Methods ──
        public void get_Manager(){} // RVA: 0x7ffaa89357c0
        public void set_Manager(){} // RVA: 0x7ffaa8998e80
        public void get_Instance(){} // RVA: 0x7ffaaf205540
        public void get_AssignedSettings(){} // RVA: 0x7ffaa89357c0
        public void get_InitManagerOnStart(){} // RVA: 0x7ffaa8a209d0
        public void Awake(){} // RVA: 0x7ffaaf2055a0
        public void Quit(){} // RVA: 0x7ffaaf205780
        public void Start(){} // RVA: 0x7ffaaf2058c0
        public void OnDestroy(){} // RVA: 0x7ffaaf2058d0
        public void AttemptInitializeXRSDKOnLoad(){} // RVA: 0x7ffaaf2058e0
        public void AttemptStartXRSDKOnBeforeSplashScreen(){} // RVA: 0x7ffaaf205a20
        public void InitXRSDK(){} // RVA: 0x7ffaaf205b60
        public void StartXRSDK(){} // RVA: 0x7ffaaf205ed0
        public void StopXRSDK(){} // RVA: 0x7ffaaf206060
        public void DeInitXRSDK(){} // RVA: 0x7ffaaf2061f0
        public void .ctor(){} // RVA: 0x7ffaaf2063e0
        public void .cctor(){} // RVA: 0x7ffaaf2063f0
    }

    public class XRLoader : ScriptableObject
    {
        // ── Original Methods ──
        public void Initialize(){} // RVA: 0x7ffaa8a17850
        public void Start(){} // RVA: 0x7ffaa8a17850
        public void Stop(){} // RVA: 0x7ffaa8a17850
        public void Deinitialize(){} // RVA: 0x7ffaa8a17850
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
        // ── Binary Analysis Named ──
        public void GetLoadedSubsystem(){} // RVA: 0x7ffaa887e5c0
        public void GetSupportedGraphicsDeviceTypes(){} // RVA: 0x7ffaaf206510
    }

    public class XRLoaderHelper : XRLoader
    {
        // ── Original Methods ──
        public void StartSubsystem(){} // RVA: 0x7ffaa8660cc0
        public void StopSubsystem(){} // RVA: 0x7ffaa8660cc0
        public void DestroySubsystem(){} // RVA: 0x7ffaa8660cc0
        public void CreateSubsystem(){} // RVA: 0x7ffaa8669e70
        public void CreateIntegratedSubsystem(){} // RVA: 0x7ffaa8669e70
        public void CreateStandaloneSubsystem(){} // RVA: 0x7ffaa8669e70
        public void Deinitialize(){} // RVA: 0x7ffaaf206570
        public void .ctor(){} // RVA: 0x7ffaaf2065c0
        // ── Binary Analysis Named ──
        public void GetLoadedSubsystem(){} // RVA: 0x7ffaa887e5c0
    }

    public class XRManagementAnalytics : Object
    {
        public object kVendorKey; // 0x339F6920

        // ── Original Methods ──
        public void Initialize(){} // RVA: 0x7ffaaf206690
    }

    public class XRManagerSettings : ScriptableObject
    {
        public object m_AutomaticLoading; // 0x319883F0
        public object m_RegisteredLoaders; // 0x319883F0

        // ── Original Methods ──
        public void get_automaticLoading(){} // RVA: 0x7ffaaa01a540
        public void set_automaticLoading(){} // RVA: 0x7ffaaa01a550
        public void get_automaticRunning(){} // RVA: 0x7ffaa8c53430
        public void set_automaticRunning(){} // RVA: 0x7ffaaa0188e0
        public void get_loaders(){} // RVA: 0x7ffaa89600c0
        public void get_activeLoaders(){} // RVA: 0x7ffaa89600c0
        public void get_isInitializationComplete(){} // RVA: 0x7ffaa894d4e0
        public void get_activeLoader(){} // RVA: 0x7ffaa8bfcc80
        public void set_activeLoader(){} // RVA: 0x7ffaa8960890
        public void ActiveLoaderAs(){} // RVA: 0x7ffaa887e5c0
        public void InitializeLoaderSync(){} // RVA: 0x7ffaaf2066d0
        public void InitializeLoader(){} // RVA: 0x7ffaaf206a00
        public void TryAddLoader(){} // RVA: 0x7ffaaf206aa0
        public void TryRemoveLoader(){} // RVA: 0x7ffaaf206cd0
        public void TrySetLoaders(){} // RVA: 0x7ffaaf206d70
        public void Awake(){} // RVA: 0x7ffaaf206f80
        public void StartSubsystems(){} // RVA: 0x7ffaaf207360
        public void StopSubsystems(){} // RVA: 0x7ffaaf2074b0
        public void DeinitializeLoader(){} // RVA: 0x7ffaaf207600
        public void Start(){} // RVA: 0x7ffaaf207760
        public void OnDisable(){} // RVA: 0x7ffaaf207780
        public void OnDestroy(){} // RVA: 0x7ffaaf2077a0
        public void get_currentLoaders(){} // RVA: 0x7ffaa89600c0
        public void set_currentLoaders(){} // RVA: 0x7ffaa89600d0
        public void get_registeredLoaders(){} // RVA: 0x7ffaa8960130
        public void .ctor(){} // RVA: 0x7ffaaf2077b0
        // ── Binary Analysis Named ──
        public void CheckGraphicsAPICompatibility(){} // RVA: 0x7ffaaf207140
    }

}