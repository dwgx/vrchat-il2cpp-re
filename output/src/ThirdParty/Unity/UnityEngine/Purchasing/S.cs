// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 12
// Methods: 76

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class ScriptingStoreCallback : Object
    {
        public UnityEngine.Purchasing.Extension.IStoreCallback m_ForwardTo; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void get_products(){} // RVA: 0x7FFE87D722B0
        public void OnSetupFailed(){} // RVA: 0x7FFE87D72300
        public void OnProductsRetrieved(){} // RVA: 0x7FFE87D72490
        public void OnPurchaseSucceeded(){} // RVA: 0x7FFE87D72620
        public void OnAllPurchasesRetrieved(){} // RVA: 0x7FFE87D72860
        public void OnPurchaseFailed(){} // RVA: 0x7FFE87D729F0
    }

    public class ScriptingUnityCallback : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
    }

    public class SerializationExtensions : Object
    {
        // ── Methods ──
        public void TryGetString(){} // RVA: 0x7FFE87D70710
    }

    public class StandardPurchasingModule : AbstractPurchasingModule
    {
        public string k_Version; // 0x18
        public UnityEngine.Purchasing.INativeStoreProvider m_NativeStoreProvider; // 0x20
        public 0x66572DEC m_RuntimePlatform; // 0x28
        public UnityEngine.Purchasing.StandardPurchasingModule ModuleInstance;
        public Uniject.IUtil _util; // 0x30
        public UnityEngine.ILogger _logger; // 0x38
        public StoreInstance _storeInstance; // 0x40
        public UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper _telemetryMetricsInstanceWrapper; // 0x48

        // ── Methods ──
        public void get_util(){} // RVA: 0x7FFE8144E200
        public void set_util(){} // RVA: 0x7FFE81129890
        public void get_logger(){} // RVA: 0x7FFE8143BA80
        public void set_logger(){} // RVA: 0x7FFE81437330
        public void get_storeInstance(){} // RVA: 0x7FFE81178740
        public void set_storeInstance(){} // RVA: 0x7FFE81123200
        public void get_telemetryMetricsInstanceWrapper(){} // RVA: 0x7FFE81176730
        public void set_telemetryMetricsInstanceWrapper(){} // RVA: 0x7FFE81176740
        public void get_telemetryDiagnosticsInstanceWrapper(){} // RVA: 0x7FFE8119C0E0
        public void set_telemetryDiagnosticsInstanceWrapper(){} // RVA: 0x7FFE812534D0
        public void .ctor(){} // RVA: 0x7FFE87D83A70
        public void get_appStore(){} // RVA: 0x7FFE8175AC90
        public void set_appStore(){} // RVA: 0x7FFE8175AE70
        public void get_useFakeStoreUIMode(){} // RVA: 0x7FFE813A7A20
        public void set_useFakeStoreUIMode(){} // RVA: 0x7FFE8175ACA0
        public void get_useFakeStoreAlways(){} // RVA: 0x7FFE81124020
        public void set_useFakeStoreAlways(){} // RVA: 0x7FFE81124030
        public void Instance(){} // RVA: 0x7FFE87D83D20 | overloaded x2
        public void Configure(){} // RVA: 0x7FFE87D84210
        public void InstantiateStore(){} // RVA: 0x7FFE87D84990
        public void InstantiateAndroid(){} // RVA: 0x7FFE87D84D80
        public void InstantiateGoogleStore(){} // RVA: 0x7FFE87D84F40
        public void BindGoogleExtension(){} // RVA: 0x7FFE87D85840
        public void BuildGooglePlayStoreConfiguration(){} // RVA: 0x7FFE87D858C0
        public void BindGoogleConfiguration(){} // RVA: 0x7FFE87D859E0
        public void BuildAndInitGooglePlayStoreServiceAar(){} // RVA: 0x7FFE87D85A60
        public void InstantiateUDP(){} // RVA: 0x7FFE87D86400
        public void InstantiateAndroidHelper(){} // RVA: 0x7FFE87D86550
        public void GetAndroidNativeStore(){} // RVA: 0x7FFE87D865C0
        public void InstantiateApple(){} // RVA: 0x7FFE87D866C0
        public void instantiateWindowsStore(){} // RVA: 0x7FFE87D86910
        public void InstantiateFakeStore(){} // RVA: 0x7FFE87D86960
        public void .cctor(){} // RVA: 0x7FFE87D86A10
    }

    public class StoreCallbackExtensionMethods : Object
    {
        // ── Methods ──
        public void FindProductById(){} // RVA: 0x7FFE87D70540
    }

    public class StoreConfiguration : Object
    {
        public 0x66676CF4 _androidStore; // 0x10

        // ── Methods ──
        public void get_androidStore(){} // RVA: 0x7FFE811485C0
        public void set_androidStore(){} // RVA: 0x7FFE810FE0C0
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Deserialize(){} // RVA: 0x7FFE87D86C00
    }

    public class StoreID : Object
    {
    }

    public class StoreListenerProxy : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D58E90
        public void OnInitialized(){} // RVA: 0x7FFE87D58F90
        public void OnInitializeFailed(){} // RVA: 0x7FFE87D59000
        public void ProcessPurchase(){} // RVA: 0x7FFE87D59070
        public void OnPurchaseFailed(){} // RVA: 0x7FFE87D590D0
        public void SendTransactionEvent(){} // RVA: 0x7FFE87D59240
    }

    public class StoreServiceInterface : Object
    {
        // ── Methods ──
        public void GetClassType(){} // RVA: 0x7FFE87D77E50
        public void GetNameProp(){} // RVA: 0x7FFE87D77F90
        public void GetName(){} // RVA: 0x7FFE87D78170
    }

    public class StoreSubscriptionInfoNotSupportedException : ReceiptParserException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D8AA40
    }

    public class SubscriptionInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D89C10 | overloaded x3
        public void isExpired(){} // RVA: 0x7FFE8164B230
        public void isCancelled(){} // RVA: 0x7FFE813DB630
        public void getExpireDate(){} // RVA: 0x7FFE8143BA80
        public void nextBillingDate(){} // RVA: 0x7FFE87D89D70
        public void accumulateIntroductoryDuration(){} // RVA: 0x7FFE87D8A080
        public void computePeriodTimeSpan(){} // RVA: 0x7FFE87D8A1C0
        public void computeExtraTime(){} // RVA: 0x7FFE87D8A300
        public void parseTimeSpan(){} // RVA: 0x7FFE87D8A5B0
        public void parsePeriodTimeSpanUnits(){} // RVA: 0x7FFE87D8A6E0
    }

    public class SubscriptionManager : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D86F80
        public void getSubscriptionInfo(){} // RVA: 0x7FFE87D870C0
        public void getAmazonAppStoreSubInfo(){} // RVA: 0x7FFE87D87610
        public void getAppleAppStoreSubInfo(){} // RVA: 0x7FFE87D877A0
        public void findMostRecentReceipt(){} // RVA: 0x7FFE87D879B0
        public void getGooglePlayStoreSubInfo(){} // RVA: 0x7FFE87D87B50
    }

}