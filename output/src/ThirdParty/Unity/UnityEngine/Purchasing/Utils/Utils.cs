// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Utils
// Classes: 3
// Methods: 10

namespace ThirdParty.Unity.UnityEngine.Purchasing.Utils
{
    public class GooglePurchaseBuilder : Object
    {
        public UnityEngine.Purchasing.IGoogleCachedQueryProductDetailsService m_CachedQueryProductDetailsService; // 0x10
        public UnityEngine.ILogger m_Logger; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void BuildPurchases(){} // RVA: 0x7FFAC99E6AA0
        public void LogWarningForException(){} // RVA: 0x7FFAC99E6CF0
        public void BuildPurchase(){} // RVA: 0x7FFAC99E6D90
        public void TryFindAllProductDetails(){} // RVA: 0x7FFAC99E71F0
    }

    public class GoogleReceiptEncoder : Object
    {
        // ── Methods ──
        public void EncodeReceipt(){} // RVA: 0x7FFAC99E7510
    }

    public class ProductDetailsConverter : Object
    {
        // ── Methods ──
        public void ConvertOnQueryProductDetailsResponse(){} // RVA: 0x7FFAC99E7690
        public void ToProductDescription(){} // RVA: 0x7FFAC99E77C0
        public void BuildProductDescription(){} // RVA: 0x7FFAC99E7820
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}