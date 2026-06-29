// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 3
// Methods: 21

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class JSONSerializer : Object
    {
        // ── Methods ──
        public void SerializeProductDef(){} // RVA: 0x7AF00FA40
        public void SerializeProductDefs(){} // RVA: 0x7AF00FA60
        public void SerializeProductDescs(){} // RVA: 0x7AF00FCF0
        public void DeserializeFailureReason(){} // RVA: 0x7AF00FF80
        public void BuildPurchaseFailureDescriptionMessage(){} // RVA: 0x7AF0103F0
        public void EncodeProductDef(){} // RVA: 0x7AF0104B0
        public void EncodeProductDesc(){} // RVA: 0x7AF010F80
        public void EncodeProductMeta(){} // RVA: 0x7AF011280
    }

    public class JSONStore : AbstractStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF01C530
        public void SetNativeStore(){} // RVA: 0x7A813E420
        public void UnityEngine.Purchasing.IStoreInternal.SetModule(){} // RVA: 0x7AF01C5D0
        public void Initialize(){} // RVA: 0x7AF01C6F0
        public void RetrieveProducts(){} // RVA: 0x7AF01C800
        public void Purchase(){} // RVA: 0x7AF01C870
        public void FinishTransaction(){} // RVA: 0x7AF01C900
        public void OnSetupFailed(){} // RVA: 0x7AF01C990
        public void OnProductsRetrieved(){} // RVA: 0x7AF01CB00
        public void OnPurchaseSucceeded(){} // RVA: 0x7AF01CB80
        public void OnPurchaseFailed(){} // RVA: 0x7AF01CC50
        public void ParseStoreSpecificPurchaseErrorCode(){} // RVA: 0x7AF01CD20
    }

    public class JavaBridge : AndroidJavaProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF00F8A0
    }

}