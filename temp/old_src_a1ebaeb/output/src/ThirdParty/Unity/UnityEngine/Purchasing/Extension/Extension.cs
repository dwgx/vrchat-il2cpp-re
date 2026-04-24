// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Extension
// Classes: 11
// Methods: 78

namespace ThirdParty.Unity.UnityEngine.Purchasing.Extension
{
    public class AbstractPurchasingModule : Object
    {
        // ── Original Methods ──
        public void Configure(){} // RVA: 0x7ffaa8660cc0
        public void RegisterStore(){} // RVA: 0x7ffaaf3d6ee0
        public void BindExtension(){} // RVA: 0x7ffaa887e5c0
        public void BindConfiguration(){} // RVA: 0x7ffaa887e5c0
        public void Configure(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class AbstractStore : Object
    {
        // ── Original Methods ──
        public void Initialize(){} // RVA: 0x7ffaa8660d80
        public void RetrieveProducts(){} // RVA: 0x7ffaa8660d80
        public void Purchase(){} // RVA: 0x7ffaa8669e70
        public void FinishTransaction(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class ICatalogProvider
    {
        // ── Original Methods ──
        public void FetchProducts(){} // RVA: 0x7ffaa8660d80
    }

    public class IPurchasingBinder
    {
        // ── Original Methods ──
        public void RegisterStore(){} // RVA: 0x7ffaa8669e70
        public void RegisterExtension(){} // RVA: 0x7ffaa887e5c0
        public void RegisterConfiguration(){} // RVA: 0x7ffaa887e5c0
    }

    public class IPurchasingModule
    {
        // ── Original Methods ──
        public void Configure(){} // RVA: 0x7ffaa8660d80
    }

    public class IStore
    {
        // ── Original Methods ──
        public void Initialize(){} // RVA: 0x7ffaa8660d80
        public void RetrieveProducts(){} // RVA: 0x7ffaa8660d80
        public void Purchase(){} // RVA: 0x7ffaa8669e70
        public void FinishTransaction(){} // RVA: 0x7ffaa8669e70
    }

    public class IStoreCallback
    {
        // ── Original Methods ──
        public void get_products(){} // RVA: 0x7ffaa86491d0
        public void OnSetupFailed(){} // RVA: 0x7ffaa8662f00
        public void OnProductsRetrieved(){} // RVA: 0x7ffaa8660d80
        public void OnPurchaseSucceeded(){} // RVA: 0x7ffaa866b2a0
        public void OnAllPurchasesRetrieved(){} // RVA: 0x7ffaa8660d80
        public void OnPurchaseFailed(){} // RVA: 0x7ffaa8660d80
    }

    public class IStoreConfiguration
    {
    }

    public class ProductDescription : Object
    {
        public object _metadata; // 0x333DFBD0, was: <metadata>k__BackingField

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3d70d0
        public void .ctor(){} // RVA: 0x7ffaaf3d70d0
        public void .ctor(){} // RVA: 0x7ffaaf3d70d0
        public void get_storeSpecificId(){} // RVA: 0x7ffaa894d380
        public void set_storeSpecificId(){} // RVA: 0x7ffaa8933e30
        public void get_metadata(){} // RVA: 0x7ffaa89600c0
        public void set_metadata(){} // RVA: 0x7ffaa89600d0
        public void get_receipt(){} // RVA: 0x7ffaa8960130
        public void set_receipt(){} // RVA: 0x7ffaa8933e90
        public void get_transactionId(){} // RVA: 0x7ffaa8bfcc80
        public void set_transactionId(){} // RVA: 0x7ffaa8960890
    }

    public class PurchaseFailureDescription : Object
    {
        public object _message; // 0x33AEE400, was: <message>k__BackingField
        public object productId; // 0x1700002C

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae10b160
        public void get_productId(){} // RVA: 0x7ffaa894d380
        public void set_productId(){} // RVA: 0x7ffaa8933e30
        public void get_reason(){} // RVA: 0x7ffaa8b945a0
        public void set_reason(){} // RVA: 0x7ffaa9357830
        public void get_message(){} // RVA: 0x7ffaa89600c0
        public void set_message(){} // RVA: 0x7ffaa89600d0
    }

    public class UnityUtil : MonoBehaviour
    {
        public object s_PcControlledPlatforms; // 0x31948030

        // ── Original Methods ──
        public void get_currentTime(){} // RVA: 0x7ffaaf406900
        public void get_persistentDataPath(){} // RVA: 0x7ffaaf406950
        public void get_deviceUniqueIdentifier(){} // RVA: 0x7ffaae538cb0
        public void get_unityVersion(){} // RVA: 0x7ffaaf4069d0
        public void get_cloudProjectId(){} // RVA: 0x7ffaaf406a50
        public void get_userId(){} // RVA: 0x7ffaaf406ad0
        public void get_gameVersion(){} // RVA: 0x7ffaaf406b80
        public void get_sessionId(){} // RVA: 0x7ffaaf406c00
        public void get_platform(){} // RVA: 0x7ffaaf406cb0
        public void get_isEditor(){} // RVA: 0x7ffaaf406d30
        public void get_deviceModel(){} // RVA: 0x7ffaae538d00
        public void get_deviceName(){} // RVA: 0x7ffaaf2ec880
        public void get_deviceType(){} // RVA: 0x7ffaaf2ec970
        public void get_operatingSystem(){} // RVA: 0x7ffaae536e80
        public void get_screenWidth(){} // RVA: 0x7ffaaf28e0e0
        public void get_screenHeight(){} // RVA: 0x7ffaaf28e130
        public void get_screenDpi(){} // RVA: 0x7ffaaf28e180
        public void get_screenOrientation(){} // RVA: 0x7ffaaf406d80
        public void Uniject.IUtil.InitiateCoroutine(){} // RVA: 0x7ffaaf406e10
        public void Uniject.IUtil.InitiateCoroutine(){} // RVA: 0x7ffaaf406e10
        public void RunOnMainThread(){} // RVA: 0x7ffaaf406f20
        public void Start(){} // RVA: 0x7ffaaf407160
        public void FindInstanceOfType(){} // RVA: 0x7ffaa887e5c0
        public void LoadResourceInstanceOfType(){} // RVA: 0x7ffaa887e5c0
        public void PcPlatform(){} // RVA: 0x7ffaaf407230
        public void DelayedCoroutine(){} // RVA: 0x7ffaaf407360
        public void Update(){} // RVA: 0x7ffaaf407470
        public void AddPauseListener(){} // RVA: 0x7ffaaf407830
        public void OnApplicationPause(){} // RVA: 0x7ffaaf407890
        public void IsClassOrSubclass(){} // RVA: 0x7ffaaf4079f0
        public void .ctor(){} // RVA: 0x7ffaaf407a80
        public void .cctor(){} // RVA: 0x7ffaaf407b80
        // ── Binary Analysis Named ──
        public void GetAnyComponentsOfType(){} // RVA: 0x7ffaa86491d0
        public void GetWaitForSeconds(){} // RVA: 0x7ffaaf407110
    }

}