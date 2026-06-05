// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 12
// Methods: 76

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class ScriptingStoreCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void get_products(){} // RVA: 0x7FFAF9CE2110
        public void OnSetupFailed(){} // RVA: 0x7FFAF9CE2160
        public void OnProductsRetrieved(){} // RVA: 0x7FFAF9CE22F0
        public void OnPurchaseSucceeded(){} // RVA: 0x7FFAF9CE2480
        public void OnAllPurchasesRetrieved(){} // RVA: 0x7FFAF9CE26C0
        public void OnPurchaseFailed(){} // RVA: 0x7FFAF9CE2850
    }

    public class ScriptingUnityCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
    }

    public class SerializationExtensions
    {
        // ── Methods ──
        public void TryGetString(){} // RVA: 0x7FFAF9CE0570
    }

    public class StandardPurchasingModule
    {
        // ── Methods ──
        public void get_util(){} // RVA: 0x7FFAF30E74D0
        public void set_util(){} // RVA: 0x7FFAF2DBB890
        public void get_logger(){} // RVA: 0x7FFAF2F476A0
        public void set_logger(){} // RVA: 0x7FFAF2F4B830
        public void get_storeInstance(){} // RVA: 0x7FFAF2E0A740
        public void set_storeInstance(){} // RVA: 0x7FFAF2DB5200
        public void get_telemetryMetricsInstanceWrapper(){} // RVA: 0x7FFAF2E08730
        public void set_telemetryMetricsInstanceWrapper(){} // RVA: 0x7FFAF2E08740
        public void get_telemetryDiagnosticsInstanceWrapper(){} // RVA: 0x7FFAF2E2E0E0
        public void set_telemetryDiagnosticsInstanceWrapper(){} // RVA: 0x7FFAF2EE54D0
        public void .ctor(){} // RVA: 0x7FFAF9CF38D0
        public void get_appStore(){} // RVA: 0x7FFAF349AB90
        public void set_appStore(){} // RVA: 0x7FFAF349AAE0
        public void get_useFakeStoreUIMode(){} // RVA: 0x7FFAF30554D0
        public void set_useFakeStoreUIMode(){} // RVA: 0x7FFAF349ACA0
        public void get_useFakeStoreAlways(){} // RVA: 0x7FFAF2DB6020
        public void set_useFakeStoreAlways(){} // RVA: 0x7FFAF2DB6030
        public void Instance(){} // RVA: 0x7FFAF9CF3B80 | overloaded x2
        public void Configure(){} // RVA: 0x7FFAF9CF4070
        public void InstantiateStore(){} // RVA: 0x7FFAF9CF47F0
        public void InstantiateAndroid(){} // RVA: 0x7FFAF9CF4BE0
        public void InstantiateGoogleStore(){} // RVA: 0x7FFAF9CF4DA0
        public void BindGoogleExtension(){} // RVA: 0x7FFAF9CF56A0
        public void BuildGooglePlayStoreConfiguration(){} // RVA: 0x7FFAF9CF5720
        public void BindGoogleConfiguration(){} // RVA: 0x7FFAF9CF5840
        public void BuildAndInitGooglePlayStoreServiceAar(){} // RVA: 0x7FFAF9CF58C0
        public void InstantiateUDP(){} // RVA: 0x7FFAF9CF6260
        public void InstantiateAndroidHelper(){} // RVA: 0x7FFAF9CF63B0
        public void GetAndroidNativeStore(){} // RVA: 0x7FFAF9CF6420
        public void InstantiateApple(){} // RVA: 0x7FFAF9CF6520
        public void instantiateWindowsStore(){} // RVA: 0x7FFAF9CF6770
        public void InstantiateFakeStore(){} // RVA: 0x7FFAF9CF67C0
        public void .cctor(){} // RVA: 0x7FFAF9CF6870
    }

    public class StoreCallbackExtensionMethods
    {
        // ── Methods ──
        public void FindProductById(){} // RVA: 0x7FFAF9CE03A0
    }

    public class StoreConfiguration
    {
        public object payloadSizeInBytes;

        // ── Methods ──
        public void get_androidStore(){} // RVA: 0x7FFAF2DDA5C0
        public void set_androidStore(){} // RVA: 0x7FFAF2D900C0
        public void .ctor(){} // RVA: 0x7FFAF2D900C0
        public void Deserialize(){} // RVA: 0x7FFAF9CF6A60
    }

    public class StoreID
    {
    }

    public class StoreListenerProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CC8CF0
        public void OnInitialized(){} // RVA: 0x7FFAF9CC8DF0
        public void OnInitializeFailed(){} // RVA: 0x7FFAF9CC8E60
        public void ProcessPurchase(){} // RVA: 0x7FFAF9CC8ED0
        public void OnPurchaseFailed(){} // RVA: 0x7FFAF9CC8F30
        public void SendTransactionEvent(){} // RVA: 0x7FFAF9CC90A0
    }

    public class StoreServiceInterface
    {
        // ── Methods ──
        public void GetClassType(){} // RVA: 0x7FFAF9CE7CB0
        public void GetNameProp(){} // RVA: 0x7FFAF9CE7DF0
        public void GetName(){} // RVA: 0x7FFAF9CE7FD0
    }

    public class StoreSubscriptionInfoNotSupportedException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CFA8A0
    }

    public class SubscriptionInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CF9A70 | overloaded x3
        public void isExpired(){} // RVA: 0x7FFAF335BED0
        public void isCancelled(){} // RVA: 0x7FFAF306ED50
        public void getExpireDate(){} // RVA: 0x7FFAF2F476A0
        public void nextBillingDate(){} // RVA: 0x7FFAF9CF9BD0
        public void accumulateIntroductoryDuration(){} // RVA: 0x7FFAF9CF9EE0
        public void computePeriodTimeSpan(){} // RVA: 0x7FFAF9CFA020
        public void computeExtraTime(){} // RVA: 0x7FFAF9CFA160
        public void parseTimeSpan(){} // RVA: 0x7FFAF9CFA410
        public void parsePeriodTimeSpanUnits(){} // RVA: 0x7FFAF9CFA540
    }

    public class SubscriptionManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CF6DE0
        public void getSubscriptionInfo(){} // RVA: 0x7FFAF9CF6F20
        public void getAmazonAppStoreSubInfo(){} // RVA: 0x7FFAF9CF7470
        public void getAppleAppStoreSubInfo(){} // RVA: 0x7FFAF9CF7600
        public void findMostRecentReceipt(){} // RVA: 0x7FFAF9CF7810
        public void getGooglePlayStoreSubInfo(){} // RVA: 0x7FFAF9CF79B0
    }

}