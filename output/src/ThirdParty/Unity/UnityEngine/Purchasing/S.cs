// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 12
// Methods: 76

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class ScriptingStoreCallback
    {
        public UnityEngine.Purchasing.Extension.IStoreCallback m_ForwardTo; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void get_products(){} // RVA: 0x7232110
        public void OnSetupFailed(){} // RVA: 0x7232160
        public void OnProductsRetrieved(){} // RVA: 0x72322F0
        public void OnPurchaseSucceeded(){} // RVA: 0x7232480
        public void OnAllPurchasesRetrieved(){} // RVA: 0x72326C0
        public void OnPurchaseFailed(){} // RVA: 0x7232850
    }

    public class ScriptingUnityCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
    }

    public class SerializationExtensions
    {
        // ── Methods ──
        public void TryGetString(){} // RVA: 0x7230570
    }

    public class StandardPurchasingModule
    {
        public string k_Version; // 0x18
        public UnityEngine.Purchasing.INativeStoreProvider m_NativeStoreProvider; // 0x20
        public 0x658954D0 m_RuntimePlatform; // 0x28
        public UnityEngine.Purchasing.StandardPurchasingModule ModuleInstance;
        public Uniject.IUtil <util>k__BackingField; // 0x30
        public UnityEngine.ILogger <logger>k__BackingField; // 0x38
        public StoreInstance <storeInstance>k__BackingField; // 0x40
        public UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper <telemetryMetricsInstanceWrapper>k__BackingField; // 0x48

        // ── Methods ──
        public void get_util(){} // RVA: 0x6374D0
        public void set_util(){} // RVA: 0x30B890
        public void get_logger(){} // RVA: 0x4976A0
        public void set_logger(){} // RVA: 0x49B830
        public void get_storeInstance(){} // RVA: 0x35A740
        public void set_storeInstance(){} // RVA: 0x305200
        public void get_telemetryMetricsInstanceWrapper(){} // RVA: 0x358730
        public void set_telemetryMetricsInstanceWrapper(){} // RVA: 0x358740
        public void get_telemetryDiagnosticsInstanceWrapper(){} // RVA: 0x37E0E0
        public void set_telemetryDiagnosticsInstanceWrapper(){} // RVA: 0x4354D0
        public void .ctor(){} // RVA: 0x72438D0
        public void get_appStore(){} // RVA: 0x9EAB90
        public void set_appStore(){} // RVA: 0x9EAAE0
        public void get_useFakeStoreUIMode(){} // RVA: 0x5A54D0
        public void set_useFakeStoreUIMode(){} // RVA: 0x9EACA0
        public void get_useFakeStoreAlways(){} // RVA: 0x306020
        public void set_useFakeStoreAlways(){} // RVA: 0x306030
        public void Instance(){} // RVA: 0x7243B80 | overloaded x2
        public void Configure(){} // RVA: 0x7244070
        public void InstantiateStore(){} // RVA: 0x72447F0
        public void InstantiateAndroid(){} // RVA: 0x7244BE0
        public void InstantiateGoogleStore(){} // RVA: 0x7244DA0
        public void BindGoogleExtension(){} // RVA: 0x72456A0
        public void BuildGooglePlayStoreConfiguration(){} // RVA: 0x7245720
        public void BindGoogleConfiguration(){} // RVA: 0x7245840
        public void BuildAndInitGooglePlayStoreServiceAar(){} // RVA: 0x72458C0
        public void InstantiateUDP(){} // RVA: 0x7246260
        public void InstantiateAndroidHelper(){} // RVA: 0x72463B0
        public void GetAndroidNativeStore(){} // RVA: 0x7246420
        public void InstantiateApple(){} // RVA: 0x7246520
        public void instantiateWindowsStore(){} // RVA: 0x7246770
        public void InstantiateFakeStore(){} // RVA: 0x72467C0
        public void .cctor(){} // RVA: 0x7246870
    }

    public class StoreCallbackExtensionMethods
    {
        // ── Methods ──
        public void FindProductById(){} // RVA: 0x72303A0
    }

    public class StoreConfiguration
    {
        public 0x6599E868 payloadSizeInBytes; // 0x10

        // ── Methods ──
        public void get_androidStore(){} // RVA: 0x32A5C0
        public void set_androidStore(){} // RVA: 0x2E00C0
        public void .ctor(){} // RVA: 0x2E00C0
        public void Deserialize(){} // RVA: 0x7246A60
    }

    public class StoreID
    {
    }

    public class StoreListenerProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7218CF0
        public void OnInitialized(){} // RVA: 0x7218DF0
        public void OnInitializeFailed(){} // RVA: 0x7218E60
        public void ProcessPurchase(){} // RVA: 0x7218ED0
        public void OnPurchaseFailed(){} // RVA: 0x7218F30
        public void SendTransactionEvent(){} // RVA: 0x72190A0
    }

    public class StoreServiceInterface
    {
        // ── Methods ──
        public void GetClassType(){} // RVA: 0x7237CB0
        public void GetNameProp(){} // RVA: 0x7237DF0
        public void GetName(){} // RVA: 0x7237FD0
    }

    public class StoreSubscriptionInfoNotSupportedException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x724A8A0
    }

    public class SubscriptionInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7249A70 | overloaded x3
        public void isExpired(){} // RVA: 0x8ABED0
        public void isCancelled(){} // RVA: 0x5BED50
        public void getExpireDate(){} // RVA: 0x4976A0
        public void nextBillingDate(){} // RVA: 0x7249BD0
        public void accumulateIntroductoryDuration(){} // RVA: 0x7249EE0
        public void computePeriodTimeSpan(){} // RVA: 0x724A020
        public void computeExtraTime(){} // RVA: 0x724A160
        public void parseTimeSpan(){} // RVA: 0x724A410
        public void parsePeriodTimeSpanUnits(){} // RVA: 0x724A540
    }

    public class SubscriptionManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7246DE0
        public void getSubscriptionInfo(){} // RVA: 0x7246F20
        public void getAmazonAppStoreSubInfo(){} // RVA: 0x7247470
        public void getAppleAppStoreSubInfo(){} // RVA: 0x7247600
        public void findMostRecentReceipt(){} // RVA: 0x7247810
        public void getGooglePlayStoreSubInfo(){} // RVA: 0x72479B0
    }

}