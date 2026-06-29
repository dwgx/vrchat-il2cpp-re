// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Utils
// Classes: 3
// Methods: 10

namespace ThirdParty.Unity.UnityEngine.Purchasing.Utils
{
    public class GooglePurchaseBuilder : Object
    {
        public object m_CachedQueryProductDetailsService;
        public object m_Logger;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void BuildPurchases(){} // RVA: 0x7DA1BC0
        public void LogWarningForException(){} // RVA: 0x7DA1E10
        public void BuildPurchase(){} // RVA: 0x7DA1EB0
        public void TryFindAllProductDetails(){} // RVA: 0x7DA2320
    }

    public class GoogleReceiptEncoder : Object
    {
        // ── Methods ──
        public void EncodeReceipt(){} // RVA: 0x7DA2640
    }

    public class ProductDetailsConverter : Object
    {
        // ── Methods ──
        public void ConvertOnQueryProductDetailsResponse(){} // RVA: 0x7DA27C0
        public void ToProductDescription(){} // RVA: 0x7DA28F0
        public void BuildProductDescription(){} // RVA: 0x7DA2950
        public void .ctor(){} // RVA: 0xB43310
    }

}