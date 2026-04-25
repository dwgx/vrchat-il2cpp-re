// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 9
// Methods: 20

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class FakeAmazonExtensions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class FakeAppleConfiguration : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class FakeAppleExtensions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class FakeGooglePlayStoreConfiguration : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class FakeGooglePlayStoreExtensions : Object
    {
        // ── Methods ──
        public void IsPurchasedProductDeferred(){} // RVA: 0x7FFAC2F21320
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class FakeMicrosoftExtensions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class FakeStore : JSONStore
    {
        public UnityEngine.Purchasing.Extension.IStoreCallback unavailableProductId; // 0x48
        public System.Collections.Generic.List`1<string> m_PurchasedProducts; // 0x50
        public bool purchaseCalled; // 0x58
        public string <unavailableProductId>k__BackingField; // 0x60
        public 0x6B27D220 UIMode; // 0x68

        // ── Methods ──
        public void get_unavailableProductId(){} // RVA: 0x7FFAC2FBF370
        public void Initialize(){} // RVA: 0x7FFAC99D6150
        public void RetrieveProducts(){} // RVA: 0x7FFAC99D6340
        public void StoreRetrieveProducts(){} // RVA: 0x7FFAC99D6540
        public void Purchase(){} // RVA: 0x7FFAC99D6D60
        public void FakePurchase(){} // RVA: 0x7FFAC99D7160
        public void FinishTransaction(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void StartUI(){}
        public void .ctor(){} // RVA: 0x7FFAC99D74B0
        public void <>n__0(){} // RVA: 0x7FFAC99D7580
    }

    public class FakeTransactionHistoryExtensions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class FakeUDPExtension : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}