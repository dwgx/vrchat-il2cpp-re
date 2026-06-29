// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Extension
// Classes: 10
// Methods: 74

namespace ThirdParty.Unity.UnityEngine.Purchasing.Extension
{
    public class AbstractPurchasingModule : Object
    {
        public object m_Binder;

        // ── Methods ──
        public void Configure(){} // RVA: 0x894290
        public void RegisterStore(){} // RVA: 0x7D70200
        public void BindExtension(){} // RVA: 0xA94080
        public void BindConfiguration(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0xB43310
    }

    public class AbstractStore : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x894320
        public void RetrieveProducts(){} // RVA: 0x894320
        public void Purchase(){} // RVA: 0x8943B0
        public void FinishTransaction(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ICatalogProvider
    {
        // ── Methods ──
        public void FetchProducts(){} // RVA: 0x894320
    }

    public class IPurchasingBinder
    {
        // ── Methods ──
        public void RegisterStore(){} // RVA: 0x8943B0
        public void RegisterExtension(){} // RVA: 0xA94080
        public void RegisterConfiguration(){} // RVA: 0xA94080
    }

    public class IPurchasingModule
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x894320
    }

    public class IStore
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x894320
        public void RetrieveProducts(){} // RVA: 0x894320
        public void Purchase(){} // RVA: 0x8943B0
        public void FinishTransaction(){} // RVA: 0x8943B0
    }

    public class IStoreCallback
    {
        // ── Methods ──
        public void get_products(){} // RVA: 0x87C0A0
        public void OnSetupFailed(){} // RVA: 0x895750
        public void OnProductsRetrieved(){} // RVA: 0x894320
        public void OnPurchaseSucceeded(){} // RVA: 0x8954D0
        public void OnAllPurchasesRetrieved(){} // RVA: 0x894320
        public void OnPurchaseFailed(){} // RVA: 0x894320
    }

    public class ProductDescription : Object
    {
        public object _storeSpecificId;
        public object type;
        public object _metadata;
        public object _receipt;
        public object _transactionId;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D703F0
        public void get_storeSpecificId(){} // RVA: 0xB5DBF0
        public void set_storeSpecificId(){} // RVA: 0xB44D60
        public void get_metadata(){} // RVA: 0xB700F0
        public void set_metadata(){} // RVA: 0xB70100
        public void get_receipt(){} // RVA: 0xB70160
        public void set_receipt(){} // RVA: 0xB44DC0
        public void get_transactionId(){} // RVA: 0xD33E60
        public void set_transactionId(){} // RVA: 0xB708C0
    }

    public class PurchaseFailureDescription : Object
    {
        public object _productId;
        public object _reason;
        public object _message;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69C9EA0
        public void get_productId(){} // RVA: 0xB5DBF0
        public void set_productId(){} // RVA: 0xB44D60
        public void get_reason(){} // RVA: 0xE62D00
        public void set_reason(){} // RVA: 0x1033F40
        public void get_message(){} // RVA: 0xB700F0
        public void set_message(){} // RVA: 0xB70100
    }

    public class UnityUtil : MonoBehaviour
    {
        public object s_Callbacks;
        public object s_CallbacksPending;
        public object s_PcControlledPlatforms;
        public object pauseListeners;

        // ── Methods ──
        public void GetAnyComponentsOfType(){} // RVA: 0x87C0A0
        public void get_currentTime(){} // RVA: 0x7D9FCB0
        public void get_persistentDataPath(){} // RVA: 0x7D9FD00
        public void get_deviceUniqueIdentifier(){} // RVA: 0x6DED910
        public void get_unityVersion(){} // RVA: 0x7D9FD50
        public void get_cloudProjectId(){} // RVA: 0x7D9FDA0
        public void get_userId(){} // RVA: 0x7D9FDF0
        public void get_gameVersion(){} // RVA: 0x7D9FE40
        public void get_sessionId(){} // RVA: 0x7D9FE90
        public void get_platform(){} // RVA: 0x7D9FEF0
        public void get_isEditor(){} // RVA: 0x7D9FF70
        public void get_deviceModel(){} // RVA: 0x6DED920
        public void get_deviceName(){} // RVA: 0x7C0FCD0
        public void get_deviceType(){} // RVA: 0x7C0FD80
        public void get_operatingSystem(){} // RVA: 0x6DEBCC0
        public void get_screenWidth(){} // RVA: 0x7B79D40
        public void get_screenHeight(){} // RVA: 0x7B79D90
        public void get_screenDpi(){} // RVA: 0x7B79DE0
        public void get_screenOrientation(){} // RVA: 0x7D9FFC0
        public void Uniject.IUtil.InitiateCoroutine(){} // RVA: 0x7DA0050
        public void RunOnMainThread(){} // RVA: 0x7DA0160
        public void GetWaitForSeconds(){} // RVA: 0x7DA0320
        public void Start(){} // RVA: 0x7DA0370
        public void FindInstanceOfType(){} // RVA: 0xA94080
        public void LoadResourceInstanceOfType(){} // RVA: 0xA94080
        public void PcPlatform(){} // RVA: 0x7DA03D0
        public void DelayedCoroutine(){} // RVA: 0x7DA0500
        public void Update(){} // RVA: 0x7DA0610
        public void AddPauseListener(){} // RVA: 0x7DA09C0
        public void OnApplicationPause(){} // RVA: 0x7DA0A60
        public void IsClassOrSubclass(){} // RVA: 0x7DA0BD0
        public void .ctor(){} // RVA: 0x7DA0C40
        public void .cctor(){} // RVA: 0x7DA0D40
    }

}