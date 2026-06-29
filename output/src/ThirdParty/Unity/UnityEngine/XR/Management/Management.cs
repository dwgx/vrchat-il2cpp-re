// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.XR.Management
// Classes: 7
// Methods: 81

namespace ThirdParty.Unity.UnityEngine.XR.Management
{
    public class XRConfigurationDataAttribute : Attribute
    {
        // ── Methods ──
        public void get_displayName(){} // RVA: 0x7A80F2570
        public void set_displayName(){} // RVA: 0x7A80D8E20
        public void get_buildSettingsKey(){} // RVA: 0x7A80DA7B0
        public void set_buildSettingsKey(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7A8CE4080
    }

    public class XRGeneralSettings : ScriptableObject
    {
        // ── Methods ──
        public void get_Manager(){} // RVA: 0x7A80DA7B0
        public void set_Manager(){} // RVA: 0x7A813E420
        public void get_Instance(){} // RVA: 0x7AEE29C80
        public void get_AssignedSettings(){} // RVA: 0x7A80DA7B0
        public void get_InitManagerOnStart(){} // RVA: 0x7A81C68D0
        public void Awake(){} // RVA: 0x7AEE29CE0
        public void Quit(){} // RVA: 0x7AEE29EC0
        public void Start(){} // RVA: 0x7AEE2A000
        public void OnDestroy(){} // RVA: 0x7AEE2A010
        public void AttemptInitializeXRSDKOnLoad(){} // RVA: 0x7AEE2A020
        public void AttemptStartXRSDKOnBeforeSplashScreen(){} // RVA: 0x7AEE2A160
        public void InitXRSDK(){} // RVA: 0x7AEE2A2A0
        public void StartXRSDK(){} // RVA: 0x7AEE2A610
        public void StopXRSDK(){} // RVA: 0x7AEE2A7A0
        public void DeInitXRSDK(){} // RVA: 0x7AEE2A930
        public void .ctor(){} // RVA: 0x7AEE2AB20
        public void .cctor(){} // RVA: 0x7AEE2AB30
    }

    public class XRLoader : ScriptableObject
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7A81BD750
        public void Start(){} // RVA: 0x7A81BD750
        public void Stop(){} // RVA: 0x7A81BD750
        public void Deinitialize(){} // RVA: 0x7A81BD750
        public void GetLoadedSubsystem(){} // RVA: 0x7A8051B10
        public void GetSupportedGraphicsDeviceTypes(){} // RVA: 0x7AEE2AC50
        public void .ctor(){} // RVA: 0x7A82F4A40
    }

    public class XRLoaderHelper : XRLoader
    {
        // ── Methods ──
        public void GetLoadedSubsystem(){} // RVA: 0x7A8051B10
        public void StartSubsystem(){} // RVA: 0x7A7E18770
        public void StopSubsystem(){} // RVA: 0x7A7E18770
        public void DestroySubsystem(){} // RVA: 0x7A7E18770
        public void CreateSubsystem(){} // RVA: 0x7A7E18890
        public void CreateIntegratedSubsystem(){} // RVA: 0x7A7E18890
        public void CreateStandaloneSubsystem(){} // RVA: 0x7A7E18890
        public void Deinitialize(){} // RVA: 0x7AEE2ACB0
        public void .ctor(){} // RVA: 0x7AEE2AD00
    }

    public class XRLoader[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class XRManagementAnalytics : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7AEE2ADD0
    }

    public class XRManagerSettings : ScriptableObject
    {
        // ── Methods ──
        public void get_automaticLoading(){} // RVA: 0x7A9956320
        public void set_automaticLoading(){} // RVA: 0x7A99561F0
        public void get_automaticRunning(){} // RVA: 0x7A8475B10
        public void set_automaticRunning(){} // RVA: 0x7A9956330
        public void get_loaders(){} // RVA: 0x7A81052C0
        public void get_activeLoaders(){} // RVA: 0x7A81052C0
        public void get_isInitializationComplete(){} // RVA: 0x7A80F26D0
        public void get_activeLoader(){} // RVA: 0x7A83F69F0
        public void set_activeLoader(){} // RVA: 0x7A8105A90
        public void ActiveLoaderAs(){} // RVA: 0x7A8051B10
        public void InitializeLoaderSync(){} // RVA: 0x7AEE2AE10
        public void InitializeLoader(){} // RVA: 0x7AEE2B170
        public void TryAddLoader(){} // RVA: 0x7AEE2B210
        public void TryRemoveLoader(){} // RVA: 0x7AEE2B440
        public void TrySetLoaders(){} // RVA: 0x7AEE2B4E0
        public void Awake(){} // RVA: 0x7AEE2B700
        public void CheckGraphicsAPICompatibility(){} // RVA: 0x7AEE2B8D0
        public void StartSubsystems(){} // RVA: 0x7AEE2BAE0
        public void StopSubsystems(){} // RVA: 0x7AEE2BC30
        public void DeinitializeLoader(){} // RVA: 0x7AEE2BD80
        public void Start(){} // RVA: 0x7AEE2BEE0
        public void OnDisable(){} // RVA: 0x7AEE2BF00
        public void OnDestroy(){} // RVA: 0x7AEE2BF20
        public void get_currentLoaders(){} // RVA: 0x7A81052C0
        public void set_currentLoaders(){} // RVA: 0x7A81052D0
        public void get_registeredLoaders(){} // RVA: 0x7A8105330
        public void .ctor(){} // RVA: 0x7AEE2BF30
    }

}