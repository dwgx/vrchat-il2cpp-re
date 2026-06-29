// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.XR.Management
// Classes: 7
// Methods: 81

namespace ThirdParty.Unity.UnityEngine.XR.Management
{
    public class XRConfigurationDataAttribute : Attribute
    {
        public object _displayName;
        public object _buildSettingsKey;

        // ── Methods ──
        public void get_displayName(){} // RVA: 0xB5DBF0
        public void set_displayName(){} // RVA: 0xB44D60
        public void get_buildSettingsKey(){} // RVA: 0xB465B0
        public void set_buildSettingsKey(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0x17C92C0
    }

    public class XRGeneralSettings : ScriptableObject
    {
        public object k_SettingsKey;
        public object s_RuntimeSettingsInstance;
        public object m_LoaderManagerInstance;
        public object m_InitManagerOnStart;
        public object m_XRManager;
        public object m_ProviderIntialized;
        public object m_ProviderStarted;

        // ── Methods ──
        public void get_Manager(){} // RVA: 0xB465B0
        public void set_Manager(){} // RVA: 0xBA9BA0
        public void get_Instance(){} // RVA: 0x7AB3460
        public void get_AssignedSettings(){} // RVA: 0xB465B0
        public void get_InitManagerOnStart(){} // RVA: 0xC38360
        public void Awake(){} // RVA: 0x7AB34C0
        public void Quit(){} // RVA: 0x7AB3670
        public void Start(){} // RVA: 0x7AB37B0
        public void OnDestroy(){} // RVA: 0x7AB37C0
        public void AttemptInitializeXRSDKOnLoad(){} // RVA: 0x7AB37D0
        public void AttemptStartXRSDKOnBeforeSplashScreen(){} // RVA: 0x7AB3910
        public void InitXRSDK(){} // RVA: 0x7AB3A50
        public void StartXRSDK(){} // RVA: 0x7AB3DC0
        public void StopXRSDK(){} // RVA: 0x7AB3F50
        public void DeInitXRSDK(){} // RVA: 0x7AB40E0
        public void .ctor(){} // RVA: 0x7AB42D0
        public void .cctor(){} // RVA: 0x7AB42E0
    }

    public class XRLoader : ScriptableObject
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0xC2E4C0
        public void Start(){} // RVA: 0xC2E4C0
        public void Stop(){} // RVA: 0xC2E4C0
        public void Deinitialize(){} // RVA: 0xC2E4C0
        public void GetLoadedSubsystem(){} // RVA: 0xA94080
        public void GetSupportedGraphicsDeviceTypes(){} // RVA: 0x7AB4400
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class XRLoaderHelper : XRLoader
    {
        public object m_SubsystemInstanceMap;

        // ── Methods ──
        public void GetLoadedSubsystem(){} // RVA: 0xA94080
        public void StartSubsystem(){} // RVA: 0x894290
        public void StopSubsystem(){} // RVA: 0x894290
        public void DestroySubsystem(){} // RVA: 0x894290
        public void CreateSubsystem(){} // RVA: 0x8943B0
        public void CreateIntegratedSubsystem(){} // RVA: 0x8943B0
        public void CreateStandaloneSubsystem(){} // RVA: 0x8943B0
        public void Deinitialize(){} // RVA: 0x7AB4460
        public void .ctor(){} // RVA: 0x7AB44B0
    }

    public class XRLoader[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class XRManagementAnalytics : Object
    {
        public object kMaxEventsPerHour;
        public object kMaxNumberOfElements;
        public object kVendorKey;
        public object kEventBuild;
        public object s_Initialized;

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7AB4580
    }

    public class XRManagerSettings : ScriptableObject
    {
        public object m_InitializationComplete;
        public object m_RequiresSettingsUpdate;
        public object m_AutomaticLoading;
        public object m_AutomaticRunning;
        public object m_Loaders;
        public object m_RegisteredLoaders;
        public object _activeLoader;

        // ── Methods ──
        public void get_automaticLoading(){} // RVA: 0x246FA20
        public void set_automaticLoading(){} // RVA: 0x246E8E0
        public void get_automaticRunning(){} // RVA: 0xF43C30
        public void set_automaticRunning(){} // RVA: 0x246FE00
        public void get_loaders(){} // RVA: 0xB700F0
        public void get_activeLoaders(){} // RVA: 0xB700F0
        public void get_isInitializationComplete(){} // RVA: 0xB5DD50
        public void get_activeLoader(){} // RVA: 0xD33E60
        public void set_activeLoader(){} // RVA: 0xB708C0
        public void ActiveLoaderAs(){} // RVA: 0xA94080
        public void InitializeLoaderSync(){} // RVA: 0x7AB4830
        public void InitializeLoader(){} // RVA: 0x7AB4B90
        public void TryAddLoader(){} // RVA: 0x7AB4C30
        public void TryRemoveLoader(){} // RVA: 0x7AB4E60
        public void TrySetLoaders(){} // RVA: 0x7AB4F00
        public void Awake(){} // RVA: 0x7AB5120
        public void CheckGraphicsAPICompatibility(){} // RVA: 0x7AB52F0
        public void StartSubsystems(){} // RVA: 0x7AB5500
        public void StopSubsystems(){} // RVA: 0x7AB5650
        public void DeinitializeLoader(){} // RVA: 0x7AB57A0
        public void Start(){} // RVA: 0x7AB5900
        public void OnDisable(){} // RVA: 0x7AB5920
        public void OnDestroy(){} // RVA: 0x7AB5940
        public void get_currentLoaders(){} // RVA: 0xB700F0
        public void set_currentLoaders(){} // RVA: 0xB70100
        public void get_registeredLoaders(){} // RVA: 0xB70160
        public void .ctor(){} // RVA: 0x7AB5950
    }

}