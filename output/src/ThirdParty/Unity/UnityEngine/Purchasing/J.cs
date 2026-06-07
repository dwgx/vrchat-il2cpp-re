// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 3
// Methods: 22

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class JSONSerializer
    {
        // ── Methods ──
        public void SerializeProductDef(){} // RVA: 0x7230650
        public void SerializeProductDefs(){} // RVA: 0x7230670
        public void SerializeProductDescs(){} // RVA: 0x7230900
        public void DeserializeFailureReason(){} // RVA: 0x7230B90
        public void BuildPurchaseFailureDescriptionMessage(){} // RVA: 0x7231000
        public void EncodeProductDef(){} // RVA: 0x72310C0
        public void EncodeProductDesc(){} // RVA: 0x7231BB0
        public void EncodeProductMeta(){} // RVA: 0x7231EB0
    }

    public class JSONStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x723CE80
        public void SetNativeStore(){} // RVA: 0x343E80
        public void UnityEngine.Purchasing.IStoreInternal.SetModule(){} // RVA: 0x723CF20
        public void Initialize(){} // RVA: 0x723D040
        public void RetrieveProducts(){} // RVA: 0x723D150
        public void Purchase(){} // RVA: 0x723D1C0
        public void FinishTransaction(){} // RVA: 0x723D250
        public void OnSetupFailed(){} // RVA: 0x723D2E0
        public void OnProductsRetrieved(){} // RVA: 0x723D450
        public void OnPurchaseSucceeded(){} // RVA: 0x723D4D0
        public void OnPurchaseFailed(){} // RVA: 0x723D5A0 | overloaded x2
        public void ParseStoreSpecificPurchaseErrorCode(){} // RVA: 0x723D670
    }

    public class JavaBridge
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x72304B0
    }

}