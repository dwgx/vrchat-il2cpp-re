// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 7
// Methods: 59

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class ScriptingStoreCallback : Object
    {
        public object products;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E90C240
        public void get_products(){} // RVA: 0x7FFD54DE9A10
        public void OnSetupFailed(){} // RVA: 0x7FFD54DE9A60
        public void OnProductsRetrieved(){} // RVA: 0x7FFD54DE9BF0
        public void OnPurchaseSucceeded(){} // RVA: 0x7FFD54DE9D80
        public void OnAllPurchasesRetrieved(){} // RVA: 0x7FFD54DE9FC0
        public void OnPurchaseFailed(){} // RVA: 0x7FFD54DEA150
    }

    public class ScriptingUnityCallback : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E90C240
    }

    public class StandardPurchasingModule : AbstractPurchasingModule
    {
        public object util;
        public object logger;
        public object storeInstance;
        public object telemetryMetricsInstanceWrapper;
        public object telemetryDiagnosticsInstanceWrapper;
        public object appStore;
        public object useFakeStoreUIMode;
        public object useFakeStoreAlways;

        // ── Methods ──
        public void get_util(){} // RVA: 0x7FFD4E5F95E0
        public void set_util(){} // RVA: 0x7FFD4E36F890
        public void get_logger(){} // RVA: 0x7FFD4E5F0140
        public void set_logger(){} // RVA: 0x7FFD4E5F0C20
        public void get_storeInstance(){} // RVA: 0x7FFD4E3BE740
        public void set_storeInstance(){} // RVA: 0x7FFD4E369200
        public void get_telemetryMetricsInstanceWrapper(){} // RVA: 0x7FFD4E3BC730
        public void set_telemetryMetricsInstanceWrapper(){} // RVA: 0x7FFD4E3BC740
        public void get_telemetryDiagnosticsInstanceWrapper(){} // RVA: 0x7FFD4E3E20E0
        public void set_telemetryDiagnosticsInstanceWrapper(){} // RVA: 0x7FFD4E4994D0
        public void .ctor(){} // RVA: 0x7FFD54DFB1D0
        public void get_appStore(){} // RVA: 0x7FFD4EA4EA40
        public void set_appStore(){} // RVA: 0x7FFD4EA4EA00
        public void get_useFakeStoreUIMode(){} // RVA: 0x7FFD4E55CBA0
        public void set_useFakeStoreUIMode(){} // RVA: 0x7FFD4EA4EB40
        public void get_useFakeStoreAlways(){} // RVA: 0x7FFD4E36A020
        public void set_useFakeStoreAlways(){} // RVA: 0x7FFD4E36A030
        public void Instance(){} // RVA: 0x7FFD54DFB480 | overloaded x2
        public void Configure(){} // RVA: 0x7FFD54DFB970
        public void InstantiateStore(){} // RVA: 0x7FFD54DFC0F0
        public void InstantiateAndroid(){} // RVA: 0x7FFD54DFC4E0
        public void InstantiateGoogleStore(){} // RVA: 0x7FFD54DFC6A0
        public void BindGoogleExtension(){} // RVA: 0x7FFD54DFCFA0
        public void BuildGooglePlayStoreConfiguration(){} // RVA: 0x7FFD54DFD020
        public void BindGoogleConfiguration(){} // RVA: 0x7FFD54DFD140
        public void BuildAndInitGooglePlayStoreServiceAar(){} // RVA: 0x7FFD54DFD1C0
        public void InstantiateUDP(){} // RVA: 0x7FFD54DFDB60
        public void InstantiateAndroidHelper(){} // RVA: 0x7FFD54DFDCB0
        public void GetAndroidNativeStore(){} // RVA: 0x7FFD54DFDD20
        public void InstantiateApple(){} // RVA: 0x7FFD54DFDE20
        public void instantiateWindowsStore(){} // RVA: 0x7FFD54DFE070
        public void InstantiateFakeStore(){} // RVA: 0x7FFD54DFE0C0
        public void .cctor(){} // RVA: 0x7FFD54DFE170
    }

    public class StoreCallbackExtensionMethods : Object
    {
        // ── Methods ──
        public void FindProductById(){} // RVA: 0x7FFD54DE7CA0
    }

    public class StoreConfiguration : Object
    {
        public object androidStore;

        // ── Methods ──
        public void get_androidStore(){} // RVA: 0x7FFD4E38E5C0
        public void set_androidStore(){} // RVA: 0x7FFD4E3440C0
        public void .ctor(){} // RVA: 0x7FFD4E3440C0
        public void Deserialize(){} // RVA: 0x7FFD54DFE360
    }

    public class StoreListenerProxy : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DD05F0
        public void OnInitialized(){} // RVA: 0x7FFD54DD06F0
        public void OnInitializeFailed(){} // RVA: 0x7FFD54DD0760
        public void ProcessPurchase(){} // RVA: 0x7FFD54DD07D0
        public void OnPurchaseFailed(){} // RVA: 0x7FFD54DD0830
        public void SendTransactionEvent(){} // RVA: 0x7FFD54DD09A0
    }

    public class SubscriptionManager : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DFE6E0
        public void getSubscriptionInfo(){} // RVA: 0x7FFD54DFE820
        public void getAmazonAppStoreSubInfo(){} // RVA: 0x7FFD54DFED70
        public void getAppleAppStoreSubInfo(){} // RVA: 0x7FFD54DFEF00
        public void findMostRecentReceipt(){} // RVA: 0x7FFD54DFF110
        public void getGooglePlayStoreSubInfo(){} // RVA: 0x7FFD54DFF2B0
    }

}