// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.XR.Management
// Classes: 6
// Methods: 67

namespace ThirdParty.Unity.UnityEngine.XR.Management
{
    public class XRConfigurationDataAttribute : Attribute
    {
        public string _displayName; // 0x10
        public string _buildSettingsKey; // 0x18

        // ── Methods ──
        public void get_displayName(){} // RVA: 0x7FFE81116380
        public void set_displayName(){} // RVA: 0x7FFE810FCE30
        public void get_buildSettingsKey(){} // RVA: 0x7FFE810FE7C0
        public void set_buildSettingsKey(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
    }

    public class XRGeneralSettings : ScriptableObject
    {
        public string k_SettingsKey;
        public UnityEngine.XR.Management.XRGeneralSettings s_RuntimeSettingsInstance; // 0x8
        public UnityEngine.XR.Management.XRManagerSettings m_LoaderManagerInstance; // 0x18
        public bool m_InitManagerOnStart; // 0x20

        // ── Methods ──
        public void get_Manager(){} // RVA: 0x7FFE810FE7C0
        public void set_Manager(){} // RVA: 0x7FFE81161E80
        public void get_Instance(){} // RVA: 0x7FFE87B8BB60
        public void get_AssignedSettings(){} // RVA: 0x7FFE810FE7C0
        public void get_InitManagerOnStart(){} // RVA: 0x7FFE811E99D0
        public void Awake(){} // RVA: 0x7FFE87B8BBC0
        public void Quit(){} // RVA: 0x7FFE87B8BDA0
        public void Start(){} // RVA: 0x7FFE87B8BEE0
        public void OnDestroy(){} // RVA: 0x7FFE87B8BEF0
        public void AttemptInitializeXRSDKOnLoad(){} // RVA: 0x7FFE87B8BF00
        public void AttemptStartXRSDKOnBeforeSplashScreen(){} // RVA: 0x7FFE87B8C040
        public void InitXRSDK(){} // RVA: 0x7FFE87B8C180
        public void StartXRSDK(){} // RVA: 0x7FFE87B8C4F0
        public void StopXRSDK(){} // RVA: 0x7FFE87B8C680
        public void DeInitXRSDK(){} // RVA: 0x7FFE87B8C810
        public void .ctor(){} // RVA: 0x7FFE87B8CA00
        public void .cctor(){} // RVA: 0x7FFE87B8CA10
    }

    public class XRLoader : ScriptableObject
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFE811E0850
        public void Start(){} // RVA: 0x7FFE811E0850
        public void Stop(){} // RVA: 0x7FFE811E0850
        public void Deinitialize(){} // RVA: 0x7FFE811E0850
        public void GetLoadedSubsystem(){} // RVA: 0x7FFE810A1420
        public void GetSupportedGraphicsDeviceTypes(){} // RVA: 0x7FFE87B8CB30
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class XRLoaderHelper : XRLoader
    {
        // ── Methods ──
        public void GetLoadedSubsystem(){} // RVA: 0x7FFE810A1420
        public void StartSubsystem(){} // RVA: 0x7FFE80E45FE0
        public void StopSubsystem(){} // RVA: 0x7FFE80E45FE0
        public void DestroySubsystem(){} // RVA: 0x7FFE80E45FE0
        public void CreateSubsystem(){} // RVA: 0x7FFE80E4F230
        public void CreateIntegratedSubsystem(){} // RVA: 0x7FFE80E4F230
        public void CreateStandaloneSubsystem(){} // RVA: 0x7FFE80E4F230
        public void Deinitialize(){} // RVA: 0x7FFE87B8CB90
        public void .ctor(){} // RVA: 0x7FFE87B8CBE0
    }

    public class XRManagementAnalytics : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFE87B8CCB0
    }

    public class XRManagerSettings : ScriptableObject
    {
        public bool m_InitializationComplete; // 0x18
        public bool m_RequiresSettingsUpdate; // 0x19
        public bool m_AutomaticLoading; // 0x1A
        public bool m_AutomaticRunning; // 0x1B
        public System.Collections.Generic.List`1<UnityEngine.XR.Management.XRLoader> m_Loaders; // 0x20
        public System.Collections.Generic.HashSet`1<UnityEngine.XR.Management.XRLoader> m_RegisteredLoaders; // 0x28
        public UnityEngine.XR.Management.XRLoader _activeLoader; // 0x30
        public object field_7; // 0x7

        // ── Methods ──
        public void get_automaticLoading(){} // RVA: 0x7FFE82930110
        public void set_automaticLoading(){} // RVA: 0x7FFE8292DD10
        public void get_automaticRunning(){} // RVA: 0x7FFE814B32C0
        public void set_automaticRunning(){} // RVA: 0x7FFE8292DD00
        public void get_loaders(){} // RVA: 0x7FFE811290C0
        public void get_activeLoaders(){} // RVA: 0x7FFE811290C0
        public void get_isInitializationComplete(){} // RVA: 0x7FFE811164E0
        public void get_activeLoader(){} // RVA: 0x7FFE8144E200
        public void set_activeLoader(){} // RVA: 0x7FFE81129890
        public void ActiveLoaderAs(){} // RVA: 0x7FFE810A1420
        public void InitializeLoaderSync(){} // RVA: 0x7FFE87B8CCF0
        public void InitializeLoader(){} // RVA: 0x7FFE87B8D020
        public void TryAddLoader(){} // RVA: 0x7FFE87B8D0C0
        public void TryRemoveLoader(){} // RVA: 0x7FFE87B8D2F0
        public void TrySetLoaders(){} // RVA: 0x7FFE87B8D390
        public void Awake(){} // RVA: 0x7FFE87B8D5A0
        public void CheckGraphicsAPICompatibility(){} // RVA: 0x7FFE87B8D760
        public void StartSubsystems(){} // RVA: 0x7FFE87B8D980
        public void StopSubsystems(){} // RVA: 0x7FFE87B8DAD0
        public void DeinitializeLoader(){} // RVA: 0x7FFE87B8DC20
        public void Start(){} // RVA: 0x7FFE87B8DD80
        public void OnDisable(){} // RVA: 0x7FFE87B8DDA0
        public void OnDestroy(){} // RVA: 0x7FFE87B8DDC0
        public void get_currentLoaders(){} // RVA: 0x7FFE811290C0
        public void set_currentLoaders(){} // RVA: 0x7FFE811290D0
        public void get_registeredLoaders(){} // RVA: 0x7FFE81129130
        public void .ctor(){} // RVA: 0x7FFE87B8DDD0
    }

}