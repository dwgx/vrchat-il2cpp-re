// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 7
// Methods: 59

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class ScriptingStoreCallback : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8f15e70
        public void get_products(){} // RVA: 0x7ffaaf3eb970
        public void OnSetupFailed(){} // RVA: 0x7ffaaf3eb9c0
        public void OnProductsRetrieved(){} // RVA: 0x7ffaaf3ebb50
        public void OnPurchaseSucceeded(){} // RVA: 0x7ffaaf3ebce0
        public void OnAllPurchasesRetrieved(){} // RVA: 0x7ffaaf3ebf20
        public void OnPurchaseFailed(){} // RVA: 0x7ffaaf3ec0b0
    }

    public class ScriptingUnityCallback : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8f15e70
    }

    public class StandardPurchasingModule : AbstractPurchasingModule
    {
        public object m_RuntimePlatform; // 0x33548BE0
        public object _logger; // 0x33548BE0, was: <logger>k__BackingField
        public object _telemetryDiagnosticsInstanceWrapper; // 0x33548BE0, was: <telemetryDiagnosticsInstanceW
        public object _useFakeStoreUIMode; // 0x33548BE0, was: <useFakeStoreUIMode>k__Backing

        // ── Original Methods ──
        public void get_util(){} // RVA: 0x7ffaa8bfcc80
        public void set_util(){} // RVA: 0x7ffaa8960890
        public void get_logger(){} // RVA: 0x7ffaa8bf45b0
        public void set_logger(){} // RVA: 0x7ffaa8bf45c0
        public void get_storeInstance(){} // RVA: 0x7ffaa89af740
        public void set_storeInstance(){} // RVA: 0x7ffaa895a200
        public void get_telemetryMetricsInstanceWrapper(){} // RVA: 0x7ffaa89ad730
        public void set_telemetryMetricsInstanceWrapper(){} // RVA: 0x7ffaa89ad740
        public void get_telemetryDiagnosticsInstanceWrapper(){} // RVA: 0x7ffaa89d30e0
        public void set_telemetryDiagnosticsInstanceWrapper(){} // RVA: 0x7ffaa8a8a4d0
        public void .ctor(){} // RVA: 0x7ffaaf3fd130
        public void get_appStore(){} // RVA: 0x7ffaa905bf10
        public void set_appStore(){} // RVA: 0x7ffaa905bde0
        public void get_useFakeStoreUIMode(){} // RVA: 0x7ffaa8b6e710
        public void set_useFakeStoreUIMode(){} // RVA: 0x7ffaa905bdd0
        public void get_useFakeStoreAlways(){} // RVA: 0x7ffaa895b020
        public void set_useFakeStoreAlways(){} // RVA: 0x7ffaa895b030
        public void Instance(){} // RVA: 0x7ffaaf3fd3e0
        public void Instance(){} // RVA: 0x7ffaaf3fd3e0
        public void Configure(){} // RVA: 0x7ffaaf3fd8d0
        public void InstantiateStore(){} // RVA: 0x7ffaaf3fe050
        public void InstantiateAndroid(){} // RVA: 0x7ffaaf3fe440
        public void InstantiateGoogleStore(){} // RVA: 0x7ffaaf3fe600
        public void BindGoogleExtension(){} // RVA: 0x7ffaaf3fef00
        public void BuildGooglePlayStoreConfiguration(){} // RVA: 0x7ffaaf3fef80
        public void BindGoogleConfiguration(){} // RVA: 0x7ffaaf3ff0a0
        public void BuildAndInitGooglePlayStoreServiceAar(){} // RVA: 0x7ffaaf3ff120
        public void InstantiateUDP(){} // RVA: 0x7ffaaf3ffac0
        public void InstantiateAndroidHelper(){} // RVA: 0x7ffaaf3ffc10
        public void InstantiateApple(){} // RVA: 0x7ffaaf3ffd80
        public void instantiateWindowsStore(){} // RVA: 0x7ffaaf3fffd0
        public void InstantiateFakeStore(){} // RVA: 0x7ffaaf400020
        public void .cctor(){} // RVA: 0x7ffaaf4000d0
        // ── Binary Analysis Named ──
        public void GetAndroidNativeStore(){} // RVA: 0x7ffaaf3ffc80
    }

    public class StoreCallbackExtensionMethods : Object
    {
        // ── Original Methods ──
        public void FindProductById(){} // RVA: 0x7ffaaf3e9c00
    }

    public class StoreConfiguration : Object
    {
        // ── Original Methods ──
        public void get_androidStore(){} // RVA: 0x7ffaa897f5c0
        public void set_androidStore(){} // RVA: 0x7ffaa89350c0
        public void .ctor(){} // RVA: 0x7ffaa89350c0
        public void Deserialize(){} // RVA: 0x7ffaaf4002c0
    }

    public class StoreListenerProxy : Object
    {
        public object m_Extensions; // 0x33A14D50

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3d2550
        public void OnInitialized(){} // RVA: 0x7ffaaf3d2650
        public void OnInitializeFailed(){} // RVA: 0x7ffaaf3d26c0
        public void ProcessPurchase(){} // RVA: 0x7ffaaf3d2730
        public void OnPurchaseFailed(){} // RVA: 0x7ffaaf3d2790
        public void SendTransactionEvent(){} // RVA: 0x7ffaaf3d2900
    }

    public class SubscriptionManager : Object
    {
        public object intro_json; // 0x3379D3D0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf400640
        public void getSubscriptionInfo(){} // RVA: 0x7ffaaf400780
        public void getAmazonAppStoreSubInfo(){} // RVA: 0x7ffaaf400cd0
        public void getAppleAppStoreSubInfo(){} // RVA: 0x7ffaaf400e60
        public void findMostRecentReceipt(){} // RVA: 0x7ffaaf401070
        public void getGooglePlayStoreSubInfo(){} // RVA: 0x7ffaaf401210
    }

}