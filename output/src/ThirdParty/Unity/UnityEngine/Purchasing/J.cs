// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 3
// Methods: 22

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class JSONSerializer : Object
    {
        // ── Methods ──
        public void SerializeProductDef(){} // RVA: 0x7FFD54DE7F50
        public void SerializeProductDefs(){} // RVA: 0x7FFD54DE7F70
        public void SerializeProductDescs(){} // RVA: 0x7FFD54DE8200
        public void DeserializeFailureReason(){} // RVA: 0x7FFD54DE8490
        public void BuildPurchaseFailureDescriptionMessage(){} // RVA: 0x7FFD54DE8900
        public void EncodeProductDef(){} // RVA: 0x7FFD54DE89C0
        public void EncodeProductDesc(){} // RVA: 0x7FFD54DE94B0
        public void EncodeProductMeta(){} // RVA: 0x7FFD54DE97B0
    }

    public class JSONStore : AbstractStore
    {
        public ra.__0 unity; // 0x10
        public ing.elfAndInterCollisionIndices m_Store; // 0x18
        public ing.p m_Module; // 0x20
        public Identifiers m_Logger; // 0x28
        public et_ScanHiddenCameras.canFrequency m_ProductDescriptionsDeserializer; // 0x30
        public ra.pAnchorPos>b__4 m_LastPurchaseFailureDescription; // 0x38
        public ing.ighth m_LastPurchaseErrorCode; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DF4780
        public void SetNativeStore(){} // RVA: 0x7FFD4E3A7E80
        public void UnityEngine.Purchasing.IStoreInternal.SetModule(){} // RVA: 0x7FFD54DF4820
        public void Initialize(){} // RVA: 0x7FFD54DF4940
        public void RetrieveProducts(){} // RVA: 0x7FFD54DF4A50
        public void Purchase(){} // RVA: 0x7FFD54DF4AC0
        public void FinishTransaction(){} // RVA: 0x7FFD54DF4B50
        public void OnSetupFailed(){} // RVA: 0x7FFD54DF4BE0
        public void OnProductsRetrieved(){} // RVA: 0x7FFD54DF4D50
        public void OnPurchaseSucceeded(){} // RVA: 0x7FFD54DF4DD0
        public void OnPurchaseFailed(){} // RVA: 0x7FFD54DF4EA0 | overloaded x2
        public void ParseStoreSpecificPurchaseErrorCode(){} // RVA: 0x7FFD54DF4F70
    }

    public class JavaBridge : AndroidJavaProxy
    {
        public ing.PersistAcrossSceneLoads forwardTo; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DE7DB0
    }

}