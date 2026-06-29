// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 4
// Methods: 19

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class IAP : Object
    {
        // ── Methods ──
        public void ConsumePurchase(){} // RVA: 0x6B4AF50
        public void GetProductsBySKU(){} // RVA: 0x6B4B170
        public void GetViewerPurchases(){} // RVA: 0x6B4B420
        public void GetViewerPurchasesDurableCache(){} // RVA: 0x6B4B5D0
        public void LaunchCheckoutFlow(){} // RVA: 0x6B4B780
        public void GetNextProductListPage(){} // RVA: 0x6B4B9E0
        public void GetNextPurchaseListPage(){} // RVA: 0x6B4BB90
    }

    public class IMicrophone
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x894290
        public void Stop(){} // RVA: 0x894290
        public void Update(){} // RVA: 0x87C0A0
    }

    public class IVoipPCMSource
    {
        // ── Methods ──
        public void GetPCM(){} // RVA: 0x885970
        public void SetSenderID(){} // RVA: 0x8943F0
        public void Update(){} // RVA: 0x894290
        public void PeekSizeElements(){} // RVA: 0x87C130
    }

    public class InviteOptions : Object
    {
        public object Handle;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B27590
        public void AddSuggestedUser(){} // RVA: 0x6B27640
        public void ClearSuggestedUsers(){} // RVA: 0x6B27710
        public void op_Explicit(){} // RVA: 0x6AF4C10
        public void Finalize(){} // RVA: 0x6B277D0
    }

}