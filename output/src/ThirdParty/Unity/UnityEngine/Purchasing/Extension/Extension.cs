// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Extension
// Classes: 11
// Methods: 78

namespace ThirdParty.Unity.UnityEngine.Purchasing.Extension
{
    public class AbstractPurchasingModule : Object
    {
        public ra.0 m_Binder; // 0x10

        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFD4E090980 | overloaded x2
        public void RegisterStore(){} // RVA: 0x7FFD54DD4F80
        public void BindExtension(){} // RVA: 0x7FFD4E2ADC40
        public void BindConfiguration(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class AbstractStore : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFD4E090A40
        public void RetrieveProducts(){} // RVA: 0x7FFD4E090A40
        public void Purchase(){} // RVA: 0x7FFD4E099B30
        public void FinishTransaction(){} // RVA: 0x7FFD4E099B30
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ICatalogProvider
    {
        // ── Methods ──
        public void FetchProducts(){} // RVA: 0x7FFD4E090A40
    }

    public class IPurchasingBinder
    {
        // ── Methods ──
        public void RegisterStore(){} // RVA: 0x7FFD4E099B30
        public void RegisterExtension(){} // RVA: 0x7FFD4E2ADC40
        public void RegisterConfiguration(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IPurchasingModule
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFD4E090A40
    }

    public class IStore
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFD4E090A40
        public void RetrieveProducts(){} // RVA: 0x7FFD4E090A40
        public void Purchase(){} // RVA: 0x7FFD4E099B30
        public void FinishTransaction(){} // RVA: 0x7FFD4E099B30
    }

    public class IStoreCallback
    {
        public object products;

        // ── Methods ──
        public void get_products(){} // RVA: 0x7FFD4E078E90
        public void OnSetupFailed(){} // RVA: 0x7FFD4E092BC0
        public void OnProductsRetrieved(){} // RVA: 0x7FFD4E090A40
        public void OnPurchaseSucceeded(){} // RVA: 0x7FFD4E09AF60
        public void OnAllPurchasesRetrieved(){} // RVA: 0x7FFD4E090A40
        public void OnPurchaseFailed(){} // RVA: 0x7FFD4E090A40
    }

    public class IStoreConfiguration
    {
    }

    public class ProductDescription : Object
    {
        public string storeSpecificId; // 0x10
        public ing.t_verification_uri metadata; // 0x18
        public ing.ÎÎÏÏÏÎÏÎÏÎÎÌÍÍÌ receipt; // 0x20
        public string transactionId; // 0x28
        public string <transactionId>k__BackingField; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DD5170 | overloaded x3
        public void get_storeSpecificId(){} // RVA: 0x7FFD4E35C380
        public void set_storeSpecificId(){} // RVA: 0x7FFD4E342E30
        public void get_metadata(){} // RVA: 0x7FFD4E36F0C0
        public void set_metadata(){} // RVA: 0x7FFD4E36F0D0
        public void get_receipt(){} // RVA: 0x7FFD4E36F130
        public void set_receipt(){} // RVA: 0x7FFD4E342E90
        public void get_transactionId(){} // RVA: 0x7FFD4E5F95E0
        public void set_transactionId(){} // RVA: 0x7FFD4E36F890
    }

    public class PurchaseFailureDescription : Object
    {
        public string productId; // 0x10
        public ing.Factor reason; // 0x18
        public string message; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53B09F50
        public void get_productId(){} // RVA: 0x7FFD4E35C380
        public void set_productId(){} // RVA: 0x7FFD4E342E30
        public void get_reason(){} // RVA: 0x7FFD4E577800
        public void set_reason(){} // RVA: 0x7FFD4ED4CD10
        public void get_message(){} // RVA: 0x7FFD4E36F0C0
        public void set_message(){} // RVA: 0x7FFD4E36F0D0
    }

    public class UnityUtil : MonoBehaviour
    {
        public URA.woDigitYearMax<ÎÌÍÏÏÌÍÏ> currentTime;
        public bool persistentDataPath; // 0x8
        public URA.woDigitYearMax<?> deviceUniqueIdentifier; // 0x10
        public URA.woDigitYearMax<ileFullDirectoryInformation<bool>> unityVersion; // 0x20

        // ── Methods ──
        public void GetAnyComponentsOfType(){} // RVA: 0x7FFD4E078E90
        public void get_currentTime(){} // RVA: 0x7FFD54E049A0
        public void get_persistentDataPath(){} // RVA: 0x7FFD54E049F0
        public void get_deviceUniqueIdentifier(){} // RVA: 0x7FFD53F37AB0
        public void get_unityVersion(){} // RVA: 0x7FFD54E04A70
        public void get_cloudProjectId(){} // RVA: 0x7FFD54E04AF0
        public void get_userId(){} // RVA: 0x7FFD54E04B70
        public void get_gameVersion(){} // RVA: 0x7FFD54E04C20
        public void get_sessionId(){} // RVA: 0x7FFD54E04CA0
        public void get_platform(){} // RVA: 0x7FFD54E04D50
        public void get_isEditor(){} // RVA: 0x7FFD54E04DD0
        public void get_deviceModel(){} // RVA: 0x7FFD53F37B00
        public void get_deviceName(){} // RVA: 0x7FFD54CEA920
        public void get_deviceType(){} // RVA: 0x7FFD54CEAA10
        public void get_operatingSystem(){} // RVA: 0x7FFD53F35C80
        public void get_screenWidth(){} // RVA: 0x7FFD54C8C180
        public void get_screenHeight(){} // RVA: 0x7FFD54C8C1D0
        public void get_screenDpi(){} // RVA: 0x7FFD54C8C220
        public void get_screenOrientation(){} // RVA: 0x7FFD54E04E20
        public void Uniject.IUtil.InitiateCoroutine(){} // RVA: 0x7FFD54E04EB0 | overloaded x2
        public void RunOnMainThread(){} // RVA: 0x7FFD54E04FC0
        public void GetWaitForSeconds(){} // RVA: 0x7FFD54E051B0
        public void Start(){} // RVA: 0x7FFD54E05200
        public void FindInstanceOfType(){} // RVA: 0x7FFD4E2ADC40
        public void LoadResourceInstanceOfType(){} // RVA: 0x7FFD4E2ADC40
        public void PcPlatform(){} // RVA: 0x7FFD54E052D0
        public void DelayedCoroutine(){} // RVA: 0x7FFD54E05400
        public void Update(){} // RVA: 0x7FFD54E05510
        public void AddPauseListener(){} // RVA: 0x7FFD54E058D0
        public void OnApplicationPause(){} // RVA: 0x7FFD54E05930
        public void IsClassOrSubclass(){} // RVA: 0x7FFD54E05A90
        public void .ctor(){} // RVA: 0x7FFD54E05B20
        public void .cctor(){} // RVA: 0x7FFD54E05C20
    }

}