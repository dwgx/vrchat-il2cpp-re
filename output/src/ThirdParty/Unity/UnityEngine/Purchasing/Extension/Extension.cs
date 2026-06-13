// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Extension
// Classes: 11
// Methods: 78

namespace ThirdParty.Unity.UnityEngine.Purchasing.Extension
{
    public class AbstractPurchasingModule
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x24A50 | overloaded x2
        public void RegisterStore(){} // RVA: 0x721D680
        public void BindExtension(){} // RVA: 0x283FA0
        public void BindConfiguration(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class AbstractStore
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x24B10
        public void RetrieveProducts(){} // RVA: 0x24B10
        public void Purchase(){} // RVA: 0x2DC60
        public void FinishTransaction(){} // RVA: 0x2DC60
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ICatalogProvider
    {
        // ── Methods ──
        public void FetchProducts(){} // RVA: 0x24B10
    }

    public class IPurchasingBinder
    {
        // ── Methods ──
        public void RegisterStore(){} // RVA: 0x2DC60
        public void RegisterExtension(){} // RVA: 0x283FA0
        public void RegisterConfiguration(){} // RVA: 0x283FA0
    }

    public class IPurchasingModule
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x24B10
    }

    public class IStore
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x24B10
        public void RetrieveProducts(){} // RVA: 0x24B10
        public void Purchase(){} // RVA: 0x2DC60
        public void FinishTransaction(){} // RVA: 0x2DC60
    }

    public class IStoreCallback
    {
        // ── Methods ──
        public void get_products(){} // RVA: 0xCD60
        public void OnSetupFailed(){} // RVA: 0x26C40
        public void OnProductsRetrieved(){} // RVA: 0x24B10
        public void OnPurchaseSucceeded(){} // RVA: 0x2F090
        public void OnAllPurchasesRetrieved(){} // RVA: 0x24B10
        public void OnPurchaseFailed(){} // RVA: 0x24B10
    }

    public class IStoreConfiguration
    {
    }

    public class ProductDescription
    {
        public string _storeSpecificId; // 0x10
        public 0x659E5A38 type; // 0x18
        public UnityEngine.Purchasing.ProductMetadata <metadata>k__BackingField; // 0x20
        public string <receipt>k__BackingField; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x721D870 | overloaded x3
        public void get_storeSpecificId(){} // RVA: 0x2F8380
        public void set_storeSpecificId(){} // RVA: 0x2DEE30
        public void get_metadata(){} // RVA: 0x30B0C0
        public void set_metadata(){} // RVA: 0x30B0D0
        public void get_receipt(){} // RVA: 0x30B130
        public void set_receipt(){} // RVA: 0x2DEE90
        public void get_transactionId(){} // RVA: 0x6374D0
        public void set_transactionId(){} // RVA: 0x30B890
    }

    public class PurchaseFailureDescription
    {
        public string _productId; // 0x10
        public 0x659E5AE8 _reason; // 0x18
        public string <message>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F528E0
        public void get_productId(){} // RVA: 0x2F8380
        public void set_productId(){} // RVA: 0x2DEE30
        public void get_reason(){} // RVA: 0x5BED50
        public void set_reason(){} // RVA: 0x6374E0
        public void get_message(){} // RVA: 0x30B0C0
        public void set_message(){} // RVA: 0x30B0D0
    }

    public class UnityUtil
    {
        public System.Collections.Generic.List`1<System.Action> s_Callbacks;
        public bool s_CallbacksPending; // 0x8
        public System.Collections.Generic.List`1<0x658954D0> s_PcControlledPlatforms; // 0x10
        public System.Collections.Generic.List`1<System.Action`1<bool>> pauseListeners; // 0x20

        // ── Methods ──
        public void GetAnyComponentsOfType(){} // RVA: 0xCD60
        public void get_currentTime(){} // RVA: 0x724D0A0
        public void get_persistentDataPath(){} // RVA: 0x724D0F0
        public void get_deviceUniqueIdentifier(){} // RVA: 0x6380700
        public void get_unityVersion(){} // RVA: 0x724D170
        public void get_cloudProjectId(){} // RVA: 0x724D1F0
        public void get_userId(){} // RVA: 0x724D270
        public void get_gameVersion(){} // RVA: 0x724D320
        public void get_sessionId(){} // RVA: 0x724D3A0
        public void get_platform(){} // RVA: 0x724D450
        public void get_isEditor(){} // RVA: 0x724D4D0
        public void get_deviceModel(){} // RVA: 0x6380750
        public void get_deviceName(){} // RVA: 0x7132390
        public void get_deviceType(){} // RVA: 0x7132480
        public void get_operatingSystem(){} // RVA: 0x637E8D0
        public void get_screenWidth(){} // RVA: 0x70D3800
        public void get_screenHeight(){} // RVA: 0x70D3850
        public void get_screenDpi(){} // RVA: 0x70D38A0
        public void get_screenOrientation(){} // RVA: 0x724D520
        public void Uniject.IUtil.InitiateCoroutine(){} // RVA: 0x724D5B0 | overloaded x2
        public void RunOnMainThread(){} // RVA: 0x724D6C0
        public void GetWaitForSeconds(){} // RVA: 0x724D8B0
        public void Start(){} // RVA: 0x724D900
        public void FindInstanceOfType(){} // RVA: 0x283FA0
        public void LoadResourceInstanceOfType(){} // RVA: 0x283FA0
        public void PcPlatform(){} // RVA: 0x724D9D0
        public void DelayedCoroutine(){} // RVA: 0x724DB00
        public void Update(){} // RVA: 0x724DC10
        public void AddPauseListener(){} // RVA: 0x724DFD0
        public void OnApplicationPause(){} // RVA: 0x724E030
        public void IsClassOrSubclass(){} // RVA: 0x724E190
        public void .ctor(){} // RVA: 0x724E220
        public void .cctor(){} // RVA: 0x724E320
    }

}