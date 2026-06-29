// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 11
// Methods: 75

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class ScriptingStoreCallback : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_products(){} // RVA: 0x7AF0114E0
        public void OnSetupFailed(){} // RVA: 0x7AF011530
        public void OnProductsRetrieved(){} // RVA: 0x7AF0116C0
        public void OnPurchaseSucceeded(){} // RVA: 0x7AF011850
        public void OnAllPurchasesRetrieved(){} // RVA: 0x7AF011A90
        public void OnPurchaseFailed(){} // RVA: 0x7AF011C20
    }

    public class ScriptingUnityCallback : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
    }

    public class SerializationExtensions : Object
    {
        // ── Methods ──
        public void TryGetString(){} // RVA: 0x7AF00F960
    }

    public class StandardPurchasingModule : AbstractPurchasingModule
    {
        // ── Methods ──
        public void get_util(){} // RVA: 0x7A83F69F0
        public void set_util(){} // RVA: 0x7A8105A90
        public void get_logger(){} // RVA: 0x7A8292C30
        public void set_logger(){} // RVA: 0x7A8296DE0
        public void get_storeInstance(){} // RVA: 0x7A8154D80
        public void set_storeInstance(){} // RVA: 0x7A80FF440
        public void get_telemetryMetricsInstanceWrapper(){} // RVA: 0x7A8152D80
        public void set_telemetryMetricsInstanceWrapper(){} // RVA: 0x7A8152D90
        public void get_telemetryDiagnosticsInstanceWrapper(){} // RVA: 0x7A8178B90
        public void set_telemetryDiagnosticsInstanceWrapper(){} // RVA: 0x7A8230620
        public void .ctor(){} // RVA: 0x7AF0230A0
        public void get_appStore(){} // RVA: 0x7A87A7DA0
        public void set_appStore(){} // RVA: 0x7A87A7CF0
        public void get_useFakeStoreUIMode(){} // RVA: 0x7A835E820
        public void set_useFakeStoreUIMode(){} // RVA: 0x7A87A7EB0
        public void get_useFakeStoreAlways(){} // RVA: 0x7A8100260
        public void set_useFakeStoreAlways(){} // RVA: 0x7A8100270
        public void Instance(){} // RVA: 0x7AF023350
        public void Configure(){} // RVA: 0x7AF023850
        public void InstantiateStore(){} // RVA: 0x7AF023FF0
        public void InstantiateAndroid(){} // RVA: 0x7AF024570
        public void InstantiateGoogleStore(){} // RVA: 0x7AF024730
        public void BindGoogleExtension(){} // RVA: 0x7AF025170
        public void BuildGooglePlayStoreConfiguration(){} // RVA: 0x7AF0251F0
        public void BindGoogleConfiguration(){} // RVA: 0x7AF025310
        public void BuildAndInitGooglePlayStoreServiceAar(){} // RVA: 0x7AF025390
        public void InstantiateUDP(){} // RVA: 0x7AF025D30
        public void InstantiateAndroidHelper(){} // RVA: 0x7AF025E80
        public void GetAndroidNativeStore(){} // RVA: 0x7AF025EF0
        public void InstantiateApple(){} // RVA: 0x7AF025FF0
        public void instantiateWindowsStore(){} // RVA: 0x7AF0261F0
        public void InstantiateFakeStore(){} // RVA: 0x7AF026240
        public void .cctor(){} // RVA: 0x7AF0262F0
    }

    public class StoreCallbackExtensionMethods : Object
    {
        // ── Methods ──
        public void FindProductById(){} // RVA: 0x7AF00F790
    }

    public class StoreConfiguration : Object
    {
        // ── Methods ──
        public void get_androidStore(){} // RVA: 0x7A8124910
        public void set_androidStore(){} // RVA: 0x7A80DA0C0
        public void .ctor(){} // RVA: 0x7A80DA0C0
        public void Deserialize(){} // RVA: 0x7AF0264E0
        public void <androidStore>k__BackingField(){} // RVA: 0x7B41AD1E8
    }

    public class StoreListenerProxy : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEFF8120
        public void OnInitialized(){} // RVA: 0x7AEFF8220
        public void OnInitializeFailed(){} // RVA: 0x7AEFF8290
        public void ProcessPurchase(){} // RVA: 0x7AEFF8300
        public void OnPurchaseFailed(){} // RVA: 0x7AEFF8360
        public void SendTransactionEvent(){} // RVA: 0x7AEFF84D0
    }

    public class StoreServiceInterface : Object
    {
        // ── Methods ──
        public void GetClassType(){} // RVA: 0x7AF0170E0
        public void GetNameProp(){} // RVA: 0x7AF017220
        public void GetName(){} // RVA: 0x7AF017400
    }

    public class StoreSubscriptionInfoNotSupportedException : ReceiptParserException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF02A310
    }

    public class SubscriptionInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF0294E0
        public void isExpired(){} // RVA: 0x7A8668BC0
        public void isCancelled(){} // RVA: 0x7A83782A0
        public void getExpireDate(){} // RVA: 0x7A8292C30
        public void nextBillingDate(){} // RVA: 0x7AF029640
        public void accumulateIntroductoryDuration(){} // RVA: 0x7AF029950
        public void computePeriodTimeSpan(){} // RVA: 0x7AF029A90
        public void computeExtraTime(){} // RVA: 0x7AF029BD0
        public void parseTimeSpan(){} // RVA: 0x7AF029E80
        public void parsePeriodTimeSpanUnits(){} // RVA: 0x7AF029FB0
    }

    public class SubscriptionManager : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF026860
        public void getSubscriptionInfo(){} // RVA: 0x7AF0269A0
        public void getAmazonAppStoreSubInfo(){} // RVA: 0x7AF026EF0
        public void getAppleAppStoreSubInfo(){} // RVA: 0x7AF027080
        public void findMostRecentReceipt(){} // RVA: 0x7AF027290
        public void getGooglePlayStoreSubInfo(){} // RVA: 0x7AF027430
        public void receipt(){} // RVA: 0x7B2EA4CA0
    }

}