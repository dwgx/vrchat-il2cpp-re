// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Extension
// Classes: 10
// Methods: 76

namespace ThirdParty.Unity.UnityEngine.Purchasing.Extension
{
    public class AbstractPurchasingModule : Object
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7A7E18770
        public void RegisterStore(){} // RVA: 0x7AEFFCB10
        public void BindExtension(){} // RVA: 0x7A8051B10
        public void BindConfiguration(){} // RVA: 0x7A8051B10
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class AbstractStore : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7A7E18800
        public void RetrieveProducts(){} // RVA: 0x7A7E18800
        public void Purchase(){} // RVA: 0x7A7E18890
        public void FinishTransaction(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ICatalogProvider
    {
        // ── Methods ──
        public void FetchProducts(){} // RVA: 0x7A7E18800
    }

    public class IPurchasingBinder
    {
        // ── Methods ──
        public void RegisterStore(){} // RVA: 0x7A7E18890
        public void RegisterExtension(){} // RVA: 0x7A8051B10
        public void RegisterConfiguration(){} // RVA: 0x7A8051B10
    }

    public class IPurchasingModule
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7A7E18800
    }

    public class IStore
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7A7E18800
        public void RetrieveProducts(){} // RVA: 0x7A7E18800
        public void Purchase(){} // RVA: 0x7A7E18890
        public void FinishTransaction(){} // RVA: 0x7A7E18890
    }

    public class IStoreCallback
    {
        // ── Methods ──
        public void get_products(){} // RVA: 0x7A7E00680
        public void OnSetupFailed(){} // RVA: 0x7A7E19BE0
        public void OnProductsRetrieved(){} // RVA: 0x7A7E18800
        public void OnPurchaseSucceeded(){} // RVA: 0x7A7E1DDC0
        public void OnAllPurchasesRetrieved(){} // RVA: 0x7A7E18800
        public void OnPurchaseFailed(){} // RVA: 0x7A7E18800
    }

    public class ProductDescription : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEFFCD00
        public void get_storeSpecificId(){} // RVA: 0x7A80F2570
        public void set_storeSpecificId(){} // RVA: 0x7A80D8E20
        public void get_metadata(){} // RVA: 0x7A81052C0
        public void set_metadata(){} // RVA: 0x7A81052D0
        public void get_receipt(){} // RVA: 0x7A8105330
        public void set_receipt(){} // RVA: 0x7A80D8E80
        public void get_transactionId(){} // RVA: 0x7A83F69F0
        public void set_transactionId(){} // RVA: 0x7A8105A90
        public void <storeSpecificId>k__BackingField(){} // RVA: 0x7B3FB4428
    }

    public class PurchaseFailureDescription : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD41100
        public void get_productId(){} // RVA: 0x7A80F2570
        public void set_productId(){} // RVA: 0x7A80D8E20
        public void get_reason(){} // RVA: 0x7A83782A0
        public void set_reason(){} // RVA: 0x7A84385B0
        public void get_message(){} // RVA: 0x7A81052C0
        public void set_message(){} // RVA: 0x7A81052D0
        public void <productId>k__BackingField(){} // RVA: 0x7B4219388
    }

    public class UnityUtil : MonoBehaviour
    {
        // ── Methods ──
        public void GetAnyComponentsOfType(){} // RVA: 0x7A7E00680
        public void get_currentTime(){} // RVA: 0x7AF02CB50
        public void get_persistentDataPath(){} // RVA: 0x7AF02CBA0
        public void get_deviceUniqueIdentifier(){} // RVA: 0x7AE16D050
        public void get_unityVersion(){} // RVA: 0x7AF02CC20
        public void get_cloudProjectId(){} // RVA: 0x7AF02CCA0
        public void get_userId(){} // RVA: 0x7AF02CD20
        public void get_gameVersion(){} // RVA: 0x7AF02CDD0
        public void get_sessionId(){} // RVA: 0x7AF02CE50
        public void get_platform(){} // RVA: 0x7AF02CF00
        public void get_isEditor(){} // RVA: 0x7AF02CF80
        public void get_deviceModel(){} // RVA: 0x7AE16D0A0
        public void get_deviceName(){} // RVA: 0x7AEF11270
        public void get_deviceType(){} // RVA: 0x7AEF11360
        public void get_operatingSystem(){} // RVA: 0x7AE16B220
        public void get_screenWidth(){} // RVA: 0x7AEEB2620
        public void get_screenHeight(){} // RVA: 0x7AEEB2670
        public void get_screenDpi(){} // RVA: 0x7AEEB26C0
        public void get_screenOrientation(){} // RVA: 0x7AF02CFD0
        public void Uniject.IUtil.InitiateCoroutine(){} // RVA: 0x7AF02D060
        public void RunOnMainThread(){} // RVA: 0x7AF02D170
        public void GetWaitForSeconds(){} // RVA: 0x7AF02D330
        public void Start(){} // RVA: 0x7AF02D380
        public void FindInstanceOfType(){} // RVA: 0x7A8051B10
        public void LoadResourceInstanceOfType(){} // RVA: 0x7A8051B10
        public void PcPlatform(){} // RVA: 0x7AF02D450
        public void DelayedCoroutine(){} // RVA: 0x7AF02D580
        public void Update(){} // RVA: 0x7AF02D690
        public void AddPauseListener(){} // RVA: 0x7AF02DA40
        public void OnApplicationPause(){} // RVA: 0x7AF02DAA0
        public void IsClassOrSubclass(){} // RVA: 0x7AF02DC10
        public void .ctor(){} // RVA: 0x7AF02DCA0
        public void .cctor(){} // RVA: 0x7AF02DDA0
    }

}