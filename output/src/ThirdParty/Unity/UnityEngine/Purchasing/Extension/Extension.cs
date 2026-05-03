// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Extension
// Classes: 11
// Methods: 78

namespace ThirdParty.Unity.UnityEngine.Purchasing.Extension
{
    public class AbstractPurchasingModule : Object
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFE80E45FE0 | overloaded x2
        public void RegisterStore(){} // RVA: 0x7FFE87D5D820
        public void BindExtension(){} // RVA: 0x7FFE810A1420
        public void BindConfiguration(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class AbstractStore : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFE80E460A0
        public void RetrieveProducts(){} // RVA: 0x7FFE80E460A0
        public void Purchase(){} // RVA: 0x7FFE80E4F230
        public void FinishTransaction(){} // RVA: 0x7FFE80E4F230
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ICatalogProvider
    {
        // ── Methods ──
        public void FetchProducts(){} // RVA: 0x7FFE80E460A0
    }

    public class IPurchasingBinder
    {
        // ── Methods ──
        public void RegisterStore(){} // RVA: 0x7FFE80E4F230
        public void RegisterExtension(){} // RVA: 0x7FFE810A1420
        public void RegisterConfiguration(){} // RVA: 0x7FFE810A1420
    }

    public class IPurchasingModule
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFE80E460A0
    }

    public class IStore
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFE80E460A0
        public void RetrieveProducts(){} // RVA: 0x7FFE80E460A0
        public void Purchase(){} // RVA: 0x7FFE80E4F230
        public void FinishTransaction(){} // RVA: 0x7FFE80E4F230
    }

    public class IStoreCallback
    {
        // ── Methods ──
        public void get_products(){} // RVA: 0x7FFE80E2E2E0
        public void OnSetupFailed(){} // RVA: 0x7FFE80E48220
        public void OnProductsRetrieved(){} // RVA: 0x7FFE80E460A0
        public void OnPurchaseSucceeded(){} // RVA: 0x7FFE80E50660
        public void OnAllPurchasesRetrieved(){} // RVA: 0x7FFE80E460A0
        public void OnPurchaseFailed(){} // RVA: 0x7FFE80E460A0
    }

    public class IStoreConfiguration
    {
    }

    public class ProductDescription : Object
    {
        public string _storeSpecificId; // 0x10
        public 0x666BCFA4 type; // 0x18
        public UnityEngine.Purchasing.ProductMetadata _metadata; // 0x20
        public string _receipt; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D5DA10 | overloaded x3
        public void get_storeSpecificId(){} // RVA: 0x7FFE81116380
        public void set_storeSpecificId(){} // RVA: 0x7FFE810FCE30
        public void get_metadata(){} // RVA: 0x7FFE811290C0
        public void set_metadata(){} // RVA: 0x7FFE811290D0
        public void get_receipt(){} // RVA: 0x7FFE81129130
        public void set_receipt(){} // RVA: 0x7FFE810FCE90
        public void get_transactionId(){} // RVA: 0x7FFE8144E200
        public void set_transactionId(){} // RVA: 0x7FFE81129890
    }

    public class PurchaseFailureDescription : Object
    {
        public string _productId; // 0x10
        public 0x666BD054 _reason; // 0x18
        public string _message; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A93700
        public void get_productId(){} // RVA: 0x7FFE81116380
        public void set_productId(){} // RVA: 0x7FFE810FCE30
        public void get_reason(){} // RVA: 0x7FFE813DB630
        public void set_reason(){} // RVA: 0x7FFE8144DF00
        public void get_message(){} // RVA: 0x7FFE811290C0
        public void set_message(){} // RVA: 0x7FFE811290D0
    }

    public class UnityUtil : MonoBehaviour
    {
        public System.Collections.Generic.List`1<System.Action> s_Callbacks;
        public bool s_CallbacksPending; // 0x8
        public System.Collections.Generic.List`1<0x66572DEC> s_PcControlledPlatforms; // 0x10
        public System.Collections.Generic.List`1<System.Action`1<bool>> pauseListeners; // 0x20
        public object field_4; // 0x1F
        public object field_5; // 0x20
        public object field_6; // 0x21
        public object field_7; // 0x22
        public object field_8; // 0x23
        public object field_9; // 0x24
        public object field_10; // 0x25
        public object field_11; // 0x26
        public object field_12; // 0x27
        public object field_13; // 0x28
        public object field_14; // 0x29
        public object field_15; // 0x2A
        public object field_16; // 0x2B
        public object field_17; // 0x2C

        // ── Methods ──
        public void GetAnyComponentsOfType(){} // RVA: 0x7FFE80E2E2E0
        public void get_currentTime(){} // RVA: 0x7FFE87D8D240
        public void get_persistentDataPath(){} // RVA: 0x7FFE87D8D290
        public void get_deviceUniqueIdentifier(){} // RVA: 0x7FFE86EC1120
        public void get_unityVersion(){} // RVA: 0x7FFE87D8D310
        public void get_cloudProjectId(){} // RVA: 0x7FFE87D8D390
        public void get_userId(){} // RVA: 0x7FFE87D8D410
        public void get_gameVersion(){} // RVA: 0x7FFE87D8D4C0
        public void get_sessionId(){} // RVA: 0x7FFE87D8D540
        public void get_platform(){} // RVA: 0x7FFE87D8D5F0
        public void get_isEditor(){} // RVA: 0x7FFE87D8D670
        public void get_deviceModel(){} // RVA: 0x7FFE86EC1170
        public void get_deviceName(){} // RVA: 0x7FFE87C73050
        public void get_deviceType(){} // RVA: 0x7FFE87C73140
        public void get_operatingSystem(){} // RVA: 0x7FFE86EBF2F0
        public void get_screenWidth(){} // RVA: 0x7FFE87C146D0
        public void get_screenHeight(){} // RVA: 0x7FFE87C14720
        public void get_screenDpi(){} // RVA: 0x7FFE87C14770
        public void get_screenOrientation(){} // RVA: 0x7FFE87D8D6C0
        public void Uniject.IUtil.InitiateCoroutine(){} // RVA: 0x7FFE87D8D750 | overloaded x2
        public void RunOnMainThread(){} // RVA: 0x7FFE87D8D860
        public void GetWaitForSeconds(){} // RVA: 0x7FFE87D8DA50
        public void Start(){} // RVA: 0x7FFE87D8DAA0
        public void FindInstanceOfType(){} // RVA: 0x7FFE810A1420
        public void LoadResourceInstanceOfType(){} // RVA: 0x7FFE810A1420
        public void PcPlatform(){} // RVA: 0x7FFE87D8DB70
        public void DelayedCoroutine(){} // RVA: 0x7FFE87D8DCA0
        public void Update(){} // RVA: 0x7FFE87D8DDB0
        public void AddPauseListener(){} // RVA: 0x7FFE87D8E170
        public void OnApplicationPause(){} // RVA: 0x7FFE87D8E1D0
        public void IsClassOrSubclass(){} // RVA: 0x7FFE87D8E330
        public void .ctor(){} // RVA: 0x7FFE87D8E3C0
        public void .cctor(){} // RVA: 0x7FFE87D8E4C0
    }

}