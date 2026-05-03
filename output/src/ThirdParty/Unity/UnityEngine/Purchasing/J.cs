// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 3
// Methods: 22

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class JSONSerializer : Object
    {
        // ── Methods ──
        public void SerializeProductDef(){} // RVA: 0x7FFE87D707F0
        public void SerializeProductDefs(){} // RVA: 0x7FFE87D70810
        public void SerializeProductDescs(){} // RVA: 0x7FFE87D70AA0
        public void DeserializeFailureReason(){} // RVA: 0x7FFE87D70D30
        public void BuildPurchaseFailureDescriptionMessage(){} // RVA: 0x7FFE87D711A0
        public void EncodeProductDef(){} // RVA: 0x7FFE87D71260
        public void EncodeProductDesc(){} // RVA: 0x7FFE87D71D50
        public void EncodeProductMeta(){} // RVA: 0x7FFE87D72050
    }

    public class JSONStore : AbstractStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D7D020
        public void SetNativeStore(){} // RVA: 0x7FFE81161E80
        public void UnityEngine.Purchasing.IStoreInternal.SetModule(){} // RVA: 0x7FFE87D7D0C0
        public void Initialize(){} // RVA: 0x7FFE87D7D1E0
        public void RetrieveProducts(){} // RVA: 0x7FFE87D7D2F0
        public void Purchase(){} // RVA: 0x7FFE87D7D360
        public void FinishTransaction(){} // RVA: 0x7FFE87D7D3F0
        public void OnSetupFailed(){} // RVA: 0x7FFE87D7D480
        public void OnProductsRetrieved(){} // RVA: 0x7FFE87D7D5F0
        public void OnPurchaseSucceeded(){} // RVA: 0x7FFE87D7D670
        public void OnPurchaseFailed(){} // RVA: 0x7FFE87D7D740 | overloaded x2
        public void ParseStoreSpecificPurchaseErrorCode(){} // RVA: 0x7FFE87D7D810
    }

    public class JavaBridge : AndroidJavaProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D70650
    }

}