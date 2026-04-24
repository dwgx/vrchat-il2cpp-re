// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 3
// Methods: 22

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class JSONSerializer : Object
    {
        // ── Original Methods ──
        public void SerializeProductDef(){} // RVA: 0x7ffaaf3e9eb0
        public void SerializeProductDefs(){} // RVA: 0x7ffaaf3e9ed0
        public void SerializeProductDescs(){} // RVA: 0x7ffaaf3ea160
        public void DeserializeFailureReason(){} // RVA: 0x7ffaaf3ea3f0
        public void BuildPurchaseFailureDescriptionMessage(){} // RVA: 0x7ffaaf3ea860
        public void EncodeProductDef(){} // RVA: 0x7ffaaf3ea920
        public void EncodeProductDesc(){} // RVA: 0x7ffaaf3eb410
        public void EncodeProductMeta(){} // RVA: 0x7ffaaf3eb710
    }

    public class JSONStore : AbstractStore
    {
        public object m_Module; // 0x30BB36E0
        public object m_LastPurchaseFailureDescription; // 0x30BB36E0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3f66e0
        public void UnityEngine.Purchasing.IStoreInternal.SetModule(){} // RVA: 0x7ffaaf3f6780
        public void Initialize(){} // RVA: 0x7ffaaf3f68a0
        public void RetrieveProducts(){} // RVA: 0x7ffaaf3f69b0
        public void Purchase(){} // RVA: 0x7ffaaf3f6a20
        public void FinishTransaction(){} // RVA: 0x7ffaaf3f6ab0
        public void OnSetupFailed(){} // RVA: 0x7ffaaf3f6b40
        public void OnProductsRetrieved(){} // RVA: 0x7ffaaf3f6cb0
        public void OnPurchaseSucceeded(){} // RVA: 0x7ffaaf3f6d30
        public void OnPurchaseFailed(){} // RVA: 0x7ffaaf3f6e00
        public void OnPurchaseFailed(){} // RVA: 0x7ffaaf3f6e00
        public void ParseStoreSpecificPurchaseErrorCode(){} // RVA: 0x7ffaaf3f6ed0
        // ── Binary Analysis Named ──
        public void SetNativeStore(){} // RVA: 0x7ffaa8998e80
    }

    public class JavaBridge : AndroidJavaProxy
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3e9d10
    }

}