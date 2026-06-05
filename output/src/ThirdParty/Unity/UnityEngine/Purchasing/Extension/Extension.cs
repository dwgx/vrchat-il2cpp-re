// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Extension
// Classes: 11
// Methods: 78

namespace ThirdParty.Unity.UnityEngine.Purchasing.Extension
{
    public class AbstractPurchasingModule
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFAF2AD4A50 | overloaded x2
        public void RegisterStore(){} // RVA: 0x7FFAF9CCD680
        public void BindExtension(){} // RVA: 0x7FFAF2D33FA0
        public void BindConfiguration(){} // RVA: 0x7FFAF2D33FA0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class AbstractStore
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAF2AD4B10
        public void RetrieveProducts(){} // RVA: 0x7FFAF2AD4B10
        public void Purchase(){} // RVA: 0x7FFAF2ADDC60
        public void FinishTransaction(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ICatalogProvider
    {
        // ── Methods ──
        public void FetchProducts(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IPurchasingBinder
    {
        // ── Methods ──
        public void RegisterStore(){} // RVA: 0x7FFAF2ADDC60
        public void RegisterExtension(){} // RVA: 0x7FFAF2D33FA0
        public void RegisterConfiguration(){} // RVA: 0x7FFAF2D33FA0
    }

    public class IPurchasingModule
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IStore
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAF2AD4B10
        public void RetrieveProducts(){} // RVA: 0x7FFAF2AD4B10
        public void Purchase(){} // RVA: 0x7FFAF2ADDC60
        public void FinishTransaction(){} // RVA: 0x7FFAF2ADDC60
    }

    public class IStoreCallback
    {
        // ── Methods ──
        public void get_products(){} // RVA: 0x7FFAF2ABCD60
        public void OnSetupFailed(){} // RVA: 0x7FFAF2AD6C40
        public void OnProductsRetrieved(){} // RVA: 0x7FFAF2AD4B10
        public void OnPurchaseSucceeded(){} // RVA: 0x7FFAF2ADF090
        public void OnAllPurchasesRetrieved(){} // RVA: 0x7FFAF2AD4B10
        public void OnPurchaseFailed(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IStoreConfiguration
    {
    }

    public class ProductDescription
    {
        public object _storeSpecificId;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CCD870 | overloaded x3
        public void get_storeSpecificId(){} // RVA: 0x7FFAF2DA8380
        public void set_storeSpecificId(){} // RVA: 0x7FFAF2D8EE30
        public void get_metadata(){} // RVA: 0x7FFAF2DBB0C0
        public void set_metadata(){} // RVA: 0x7FFAF2DBB0D0
        public void get_receipt(){} // RVA: 0x7FFAF2DBB130
        public void set_receipt(){} // RVA: 0x7FFAF2D8EE90
        public void get_transactionId(){} // RVA: 0x7FFAF30E74D0
        public void set_transactionId(){} // RVA: 0x7FFAF2DBB890
    }

    public class PurchaseFailureDescription
    {
        public object _productId;
        public object _reason;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8A028E0
        public void get_productId(){} // RVA: 0x7FFAF2DA8380
        public void set_productId(){} // RVA: 0x7FFAF2D8EE30
        public void get_reason(){} // RVA: 0x7FFAF306ED50
        public void set_reason(){} // RVA: 0x7FFAF30E74E0
        public void get_message(){} // RVA: 0x7FFAF2DBB0C0
        public void set_message(){} // RVA: 0x7FFAF2DBB0D0
    }

    public class UnityUtil
    {
        // ── Methods ──
        public void GetAnyComponentsOfType(){} // RVA: 0x7FFAF2ABCD60
        public void get_currentTime(){} // RVA: 0x7FFAF9CFD0A0
        public void get_persistentDataPath(){} // RVA: 0x7FFAF9CFD0F0
        public void get_deviceUniqueIdentifier(){} // RVA: 0x7FFAF8E30700
        public void get_unityVersion(){} // RVA: 0x7FFAF9CFD170
        public void get_cloudProjectId(){} // RVA: 0x7FFAF9CFD1F0
        public void get_userId(){} // RVA: 0x7FFAF9CFD270
        public void get_gameVersion(){} // RVA: 0x7FFAF9CFD320
        public void get_sessionId(){} // RVA: 0x7FFAF9CFD3A0
        public void get_platform(){} // RVA: 0x7FFAF9CFD450
        public void get_isEditor(){} // RVA: 0x7FFAF9CFD4D0
        public void get_deviceModel(){} // RVA: 0x7FFAF8E30750
        public void get_deviceName(){} // RVA: 0x7FFAF9BE2390
        public void get_deviceType(){} // RVA: 0x7FFAF9BE2480
        public void get_operatingSystem(){} // RVA: 0x7FFAF8E2E8D0
        public void get_screenWidth(){} // RVA: 0x7FFAF9B83800
        public void get_screenHeight(){} // RVA: 0x7FFAF9B83850
        public void get_screenDpi(){} // RVA: 0x7FFAF9B838A0
        public void get_screenOrientation(){} // RVA: 0x7FFAF9CFD520
        public void Uniject.IUtil.InitiateCoroutine(){} // RVA: 0x7FFAF9CFD5B0 | overloaded x2
        public void RunOnMainThread(){} // RVA: 0x7FFAF9CFD6C0
        public void GetWaitForSeconds(){} // RVA: 0x7FFAF9CFD8B0
        public void Start(){} // RVA: 0x7FFAF9CFD900
        public void FindInstanceOfType(){} // RVA: 0x7FFAF2D33FA0
        public void LoadResourceInstanceOfType(){} // RVA: 0x7FFAF2D33FA0
        public void PcPlatform(){} // RVA: 0x7FFAF9CFD9D0
        public void DelayedCoroutine(){} // RVA: 0x7FFAF9CFDB00
        public void Update(){} // RVA: 0x7FFAF9CFDC10
        public void AddPauseListener(){} // RVA: 0x7FFAF9CFDFD0
        public void OnApplicationPause(){} // RVA: 0x7FFAF9CFE030
        public void IsClassOrSubclass(){} // RVA: 0x7FFAF9CFE190
        public void .ctor(){} // RVA: 0x7FFAF9CFE220
        public void .cctor(){} // RVA: 0x7FFAF9CFE320
    }

}