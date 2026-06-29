// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 11
// Methods: 73

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class ScriptingStoreCallback : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_products(){} // RVA: 0x7D84AF0
        public void OnSetupFailed(){} // RVA: 0x7D84B40
        public void OnProductsRetrieved(){} // RVA: 0x7D84CD0
        public void OnPurchaseSucceeded(){} // RVA: 0x7D84E60
        public void OnAllPurchasesRetrieved(){} // RVA: 0x7D850A0
        public void OnPurchaseFailed(){} // RVA: 0x7D85230
    }

    public class ScriptingUnityCallback : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
    }

    public class SerializationExtensions : Object
    {
        // ── Methods ──
        public void TryGetString(){} // RVA: 0x7D83010
    }

    public class StandardPurchasingModule : AbstractPurchasingModule
    {
        // ── Methods ──
        public void get_util(){} // RVA: 0xD33E60
        public void set_util(){} // RVA: 0xB708C0
        public void get_logger(){} // RVA: 0xD05CA0
        public void set_logger(){} // RVA: 0xD09D70
        public void get_storeInstance(){} // RVA: 0xBC1B30
        public void set_storeInstance(){} // RVA: 0xB6A8C0
        public void get_telemetryMetricsInstanceWrapper(){} // RVA: 0xBBF8F0
        public void set_telemetryMetricsInstanceWrapper(){} // RVA: 0xBBF900
        public void get_telemetryDiagnosticsInstanceWrapper(){} // RVA: 0xBE58B0
        public void set_telemetryDiagnosticsInstanceWrapper(){} // RVA: 0xCA4DF0
        public void .ctor(){} // RVA: 0x7D963D0
        public void get_appStore(){} // RVA: 0x12BB630
        public void set_appStore(){} // RVA: 0x12BB640
        public void get_useFakeStoreUIMode(){} // RVA: 0xE36310
        public void set_useFakeStoreUIMode(){} // RVA: 0x12BB610
        public void get_useFakeStoreAlways(){} // RVA: 0xB6B1A0
        public void set_useFakeStoreAlways(){} // RVA: 0xB6B1B0
        public void Instance(){} // RVA: 0x7D96680
        public void Configure(){} // RVA: 0x7D96B40
        public void InstantiateStore(){} // RVA: 0x7D972F0
        public void InstantiateAndroid(){} // RVA: 0x7D97870
        public void InstantiateGoogleStore(){} // RVA: 0x7D97A30
        public void BindGoogleExtension(){} // RVA: 0x7D98470
        public void BuildGooglePlayStoreConfiguration(){} // RVA: 0x7D984F0
        public void BindGoogleConfiguration(){} // RVA: 0x7D98610
        public void BuildAndInitGooglePlayStoreServiceAar(){} // RVA: 0x7D98690
        public void InstantiateUDP(){} // RVA: 0x7D99030
        public void InstantiateAndroidHelper(){} // RVA: 0x7D99180
        public void GetAndroidNativeStore(){} // RVA: 0x7D991F0
        public void InstantiateApple(){} // RVA: 0x7D992F0
        public void instantiateWindowsStore(){} // RVA: 0x7D994F0
        public void InstantiateFakeStore(){} // RVA: 0x7D99540
        public void .cctor(){} // RVA: 0x7D995F0
    }

    public class StoreCallbackExtensionMethods : Object
    {
        // ── Methods ──
        public void FindProductById(){} // RVA: 0x7D82E40
    }

    public class StoreConfiguration : Object
    {
        // ── Methods ──
        public void get_androidStore(){} // RVA: 0xB8F8F0
        public void set_androidStore(){} // RVA: 0xB460A0
        public void .ctor(){} // RVA: 0xB460A0
        public void Deserialize(){} // RVA: 0x7D997E0
    }

    public class StoreListenerProxy : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D6B860
        public void OnInitialized(){} // RVA: 0x7D6B960
        public void OnInitializeFailed(){} // RVA: 0x7D6B9D0
        public void ProcessPurchase(){} // RVA: 0x7D6BA40
        public void OnPurchaseFailed(){} // RVA: 0x7D6BAA0
        public void SendTransactionEvent(){} // RVA: 0x7D6BC10
    }

    public class StoreServiceInterface : Object
    {
        // ── Methods ──
        public void GetClassType(){} // RVA: 0x7D8A510
        public void GetNameProp(){} // RVA: 0x7D8A640
        public void GetName(){} // RVA: 0x7D8A810
    }

    public class StoreSubscriptionInfoNotSupportedException : ReceiptParserException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D9D4B0
    }

    public class SubscriptionInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D9C6A0
        public void isExpired(){} // RVA: 0x116A650
        public void isCancelled(){} // RVA: 0xE62D00
        public void getExpireDate(){} // RVA: 0xD05CA0
        public void nextBillingDate(){} // RVA: 0x7D9C800
        public void accumulateIntroductoryDuration(){} // RVA: 0x7D9CB10
        public void computePeriodTimeSpan(){} // RVA: 0x7D9CC50
        public void computeExtraTime(){} // RVA: 0x7D9CD90
        public void parseTimeSpan(){} // RVA: 0x7D9D020
        public void parsePeriodTimeSpanUnits(){} // RVA: 0x7D9D150
    }

    public class SubscriptionManager : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D99B10
        public void getSubscriptionInfo(){} // RVA: 0x7D99C50
        public void getAmazonAppStoreSubInfo(){} // RVA: 0x7D9A190
        public void getAppleAppStoreSubInfo(){} // RVA: 0x7D9A320
        public void findMostRecentReceipt(){} // RVA: 0x7D9A530
        public void getGooglePlayStoreSubInfo(){} // RVA: 0x7D9A6D0
    }

}