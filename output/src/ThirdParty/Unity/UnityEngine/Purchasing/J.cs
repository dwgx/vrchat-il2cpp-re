// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 3
// Methods: 21

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class JSONSerializer : Object
    {
        // ── Methods ──
        public void SerializeProductDef(){} // RVA: 0x7D830F0
        public void SerializeProductDefs(){} // RVA: 0x7D83110
        public void SerializeProductDescs(){} // RVA: 0x7D833A0
        public void DeserializeFailureReason(){} // RVA: 0x7D83630
        public void BuildPurchaseFailureDescriptionMessage(){} // RVA: 0x7D83AB0
        public void EncodeProductDef(){} // RVA: 0x7D83B70
        public void EncodeProductDesc(){} // RVA: 0x7D845D0
        public void EncodeProductMeta(){} // RVA: 0x7D848A0
    }

    public class JSONStore : AbstractStore
    {
        public object unity;
        public object m_Store;
        public object m_Module;
        public object m_Logger;
        public object m_ProductDescriptionsDeserializer;
        public object m_LastPurchaseFailureDescription;
        public object m_LastPurchaseErrorCode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D8FA30
        public void SetNativeStore(){} // RVA: 0xBA9BA0
        public void UnityEngine.Purchasing.IStoreInternal.SetModule(){} // RVA: 0x7D8FAD0
        public void Initialize(){} // RVA: 0x7D8FBF0
        public void RetrieveProducts(){} // RVA: 0x7D8FD00
        public void Purchase(){} // RVA: 0x7D8FD70
        public void FinishTransaction(){} // RVA: 0x7D8FE00
        public void OnSetupFailed(){} // RVA: 0x7D8FE90
        public void OnProductsRetrieved(){} // RVA: 0x7D8FFC0
        public void OnPurchaseSucceeded(){} // RVA: 0x7D90040
        public void OnPurchaseFailed(){} // RVA: 0x7D90110
        public void ParseStoreSpecificPurchaseErrorCode(){} // RVA: 0x7D901E0
    }

    public class JavaBridge : AndroidJavaProxy
    {
        public object forwardTo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D82F50
    }

}