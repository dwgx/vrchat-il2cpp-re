// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 12
// Methods: 76

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class ScriptingStoreCallback : Object
    {
        public UnityEngine.Purchasing.Extension.IStoreCallback products; // 0x10
        public Uniject.IUtil m_Util; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void get_products(){} // RVA: 0x7FFAC99C9A10
        public void OnSetupFailed(){} // RVA: 0x7FFAC99C9A60
        public void OnProductsRetrieved(){} // RVA: 0x7FFAC99C9BF0
        public void OnPurchaseSucceeded(){} // RVA: 0x7FFAC99C9D80
        public void OnAllPurchasesRetrieved(){} // RVA: 0x7FFAC99C9FC0
        public void OnPurchaseFailed(){} // RVA: 0x7FFAC99CA150
    }

    public class ScriptingUnityCallback : Object
    {
        public UnityEngine.Purchasing.IUnityCallback forwardTo; // 0x10
        public Uniject.IUtil util; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
    }

    public class SerializationExtensions : Object
    {
        // ── Methods ──
        public void TryGetString(){} // RVA: 0x7FFAC99C7E70
    }

    public class StandardPurchasingModule : AbstractPurchasingModule
    {
        public string util; // 0x18
        public UnityEngine.Purchasing.INativeStoreProvider logger; // 0x20
        public 0x6B179580 storeInstance; // 0x28
        public UnityEngine.Purchasing.StandardPurchasingModule telemetryMetricsInstanceWrapper;
        public Uniject.IUtil telemetryDiagnosticsInstanceWrapper; // 0x30
        public UnityEngine.ILogger appStore; // 0x38
        public StoreInstance useFakeStoreUIMode; // 0x40
        public UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper useFakeStoreAlways; // 0x48
        public UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper <telemetryDiagnosticsInstanceWrapper>k__BackingField; // 0x50
        public System.Collections.Generic.Dictionary`2<0x6B27CF08,string> AndroidStoreNameMap; // 0x8
        public 0x6B27CF08 <appStore>k__BackingField; // 0x58
        public 0x6B27D220 <useFakeStoreUIMode>k__BackingField; // 0x5C
        public bool <useFakeStoreAlways>k__BackingField; // 0x60
        public UnityEngine.Purchasing.WinRTStore windowsStore; // 0x68

        // ── Methods ──
        public void get_util(){} // RVA: 0x7FFAC31D95E0
        public void set_util(){} // RVA: 0x7FFAC2F4F890
        public void get_logger(){} // RVA: 0x7FFAC31D0140
        public void set_logger(){} // RVA: 0x7FFAC31D0C20
        public void get_storeInstance(){} // RVA: 0x7FFAC2F9E740
        public void set_storeInstance(){} // RVA: 0x7FFAC2F49200
        public void get_telemetryMetricsInstanceWrapper(){} // RVA: 0x7FFAC2F9C730
        public void set_telemetryMetricsInstanceWrapper(){} // RVA: 0x7FFAC2F9C740
        public void get_telemetryDiagnosticsInstanceWrapper(){} // RVA: 0x7FFAC2FC20E0
        public void set_telemetryDiagnosticsInstanceWrapper(){} // RVA: 0x7FFAC30794D0
        public void .ctor(){} // RVA: 0x7FFAC99DB1D0
        public void get_appStore(){} // RVA: 0x7FFAC362EA40
        public void set_appStore(){} // RVA: 0x7FFAC362EA00
        public void get_useFakeStoreUIMode(){} // RVA: 0x7FFAC313CBA0
        public void set_useFakeStoreUIMode(){} // RVA: 0x7FFAC362EB40
        public void get_useFakeStoreAlways(){} // RVA: 0x7FFAC2F4A020
        public void set_useFakeStoreAlways(){} // RVA: 0x7FFAC2F4A030
        public void Instance(){} // RVA: 0x7FFAC99DB480 | overloaded x2
        public void Configure(){} // RVA: 0x7FFAC99DB970
        public void InstantiateStore(){} // RVA: 0x7FFAC99DC0F0
        public void InstantiateAndroid(){} // RVA: 0x7FFAC99DC4E0
        public void InstantiateGoogleStore(){} // RVA: 0x7FFAC99DC6A0
        public void BindGoogleExtension(){} // RVA: 0x7FFAC99DCFA0
        public void BuildGooglePlayStoreConfiguration(){} // RVA: 0x7FFAC99DD020
        public void BindGoogleConfiguration(){} // RVA: 0x7FFAC99DD140
        public void BuildAndInitGooglePlayStoreServiceAar(){} // RVA: 0x7FFAC99DD1C0
        public void InstantiateUDP(){} // RVA: 0x7FFAC99DDB60
        public void InstantiateAndroidHelper(){} // RVA: 0x7FFAC99DDCB0
        public void GetAndroidNativeStore(){} // RVA: 0x7FFAC99DDD20
        public void InstantiateApple(){} // RVA: 0x7FFAC99DDE20
        public void instantiateWindowsStore(){} // RVA: 0x7FFAC99DE070
        public void InstantiateFakeStore(){} // RVA: 0x7FFAC99DE0C0
        public void .cctor(){} // RVA: 0x7FFAC99DE170
    }

    public class StoreCallbackExtensionMethods : Object
    {
        // ── Methods ──
        public void FindProductById(){} // RVA: 0x7FFAC99C7CA0
    }

    public class StoreConfiguration : Object
    {
        public 0x6B27CF08 androidStore; // 0x10

        // ── Methods ──
        public void get_androidStore(){} // RVA: 0x7FFAC2F6E5C0
        public void set_androidStore(){} // RVA: 0x7FFAC2F240C0
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void Deserialize(){} // RVA: 0x7FFAC99DE360
    }

    public class StoreID : Object
    {
    }

    public class StoreListenerProxy : Object
    {
        public UnityEngine.Purchasing.IAnalyticsClient m_Analytics; // 0x10
        public UnityEngine.Purchasing.IStoreListener m_ForwardTo; // 0x18
        public UnityEngine.Purchasing.IExtensionProvider m_Extensions; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99B05F0
        public void OnInitialized(){} // RVA: 0x7FFAC99B06F0
        public void OnInitializeFailed(){} // RVA: 0x7FFAC99B0760
        public void ProcessPurchase(){} // RVA: 0x7FFAC99B07D0
        public void OnPurchaseFailed(){} // RVA: 0x7FFAC99B0830
        public void SendTransactionEvent(){} // RVA: 0x7FFAC99B09A0
    }

    public class StoreServiceInterface : Object
    {
        public System.Type s_typeCache;

        // ── Methods ──
        public void GetClassType(){} // RVA: 0x7FFAC99CF5B0
        public void GetNameProp(){} // RVA: 0x7FFAC99CF6F0
        public void GetName(){} // RVA: 0x7FFAC99CF8D0
    }

    public class StoreSubscriptionInfoNotSupportedException : ReceiptParserException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99E21A0
    }

    public class SubscriptionInfo : Object
    {
        public 0x6B27DCC8 is_subscribed; // 0x10
        public 0x6B27DCC8 is_expired; // 0x14
        public 0x6B27DCC8 is_cancelled; // 0x18
        public 0x6B27DCC8 is_free_trial; // 0x1C
        public 0x6B27DCC8 is_auto_renewing; // 0x20
        public 0x6B27DCC8 is_introductory_price_period; // 0x24
        public string productId; // 0x28
        public System.DateTime purchaseDate; // 0x30
        public System.DateTime subscriptionExpireDate; // 0x38
        public System.DateTime subscriptionCancelDate; // 0x40
        public System.TimeSpan remainedTime; // 0x48
        public string introductory_price; // 0x50
        public System.TimeSpan introductory_price_period; // 0x58
        public long introductory_price_cycles; // 0x60
        public System.TimeSpan freeTrialPeriod; // 0x68
        public System.TimeSpan subscriptionPeriod; // 0x70
        public string free_trial_period_string; // 0x78
        public string sku_details; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99E1370 | overloaded x3
        public void isExpired(){} // RVA: 0x7FFAC33D5A20
        public void isCancelled(){} // RVA: 0x7FFAC3157800
        public void getExpireDate(){} // RVA: 0x7FFAC31D0140
        public void nextBillingDate(){} // RVA: 0x7FFAC99E14D0
        public void accumulateIntroductoryDuration(){} // RVA: 0x7FFAC99E17E0
        public void computePeriodTimeSpan(){} // RVA: 0x7FFAC99E1920
        public void computeExtraTime(){} // RVA: 0x7FFAC99E1A60
        public void parseTimeSpan(){} // RVA: 0x7FFAC99E1D10
        public void parsePeriodTimeSpanUnits(){} // RVA: 0x7FFAC99E1E40
    }

    public class SubscriptionManager : Object
    {
        public string receipt; // 0x10
        public string productId; // 0x18
        public string intro_json; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99DE6E0
        public void getSubscriptionInfo(){} // RVA: 0x7FFAC99DE820
        public void getAmazonAppStoreSubInfo(){} // RVA: 0x7FFAC99DED70
        public void getAppleAppStoreSubInfo(){} // RVA: 0x7FFAC99DEF00
        public void findMostRecentReceipt(){} // RVA: 0x7FFAC99DF110
        public void getGooglePlayStoreSubInfo(){} // RVA: 0x7FFAC99DF2B0
    }

}