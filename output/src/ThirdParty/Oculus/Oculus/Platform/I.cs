// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 4
// Methods: 19

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class IAP : Object
    {
        // ── Methods ──
        public void ConsumePurchase(){} // RVA: 0x7FFAC886F180
        public void GetProductsBySKU(){} // RVA: 0x7FFAC886F3A0
        public void GetViewerPurchases(){} // RVA: 0x7FFAC886F650
        public void GetViewerPurchasesDurableCache(){} // RVA: 0x7FFAC886F800
        public void LaunchCheckoutFlow(){} // RVA: 0x7FFAC886F9B0
        public void GetNextProductListPage(){} // RVA: 0x7FFAC886FC10
        public void GetNextPurchaseListPage(){} // RVA: 0x7FFAC886FDC0
    }

    public class IMicrophone
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC2C70980
        public void Stop(){} // RVA: 0x7FFAC2C70980
        public void Update(){} // RVA: 0x7FFAC2C58E90
    }

    public class IVoipPCMSource
    {
        // ── Methods ──
        public void GetPCM(){}
        public void SetSenderID(){} // RVA: 0x7FFAC2C70BF0
        public void Update(){} // RVA: 0x7FFAC2C70980
        public void PeekSizeElements(){} // RVA: 0x7FFAC2C59960
    }

    public class InviteOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC884B7C0
        public void AddSuggestedUser(){} // RVA: 0x7FFAC884B870
        public void ClearSuggestedUsers(){} // RVA: 0x7FFAC884B940
        public void op_Explicit(){} // RVA: 0x7FFAC8818EF0
        public void Finalize(){} // RVA: 0x7FFAC884BA00
    }

}