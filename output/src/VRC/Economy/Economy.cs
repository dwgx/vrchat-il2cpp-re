// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Economy
// Classes: 4
// Methods: 43

namespace VRC.Economy
{
    public class IProduct
    {
        public object _iD;

        // ── Methods ──
        public void get_ID(){} // RVA: 0xCD60
        public void get_Name(){} // RVA: 0xCD60
        public void get_Description(){} // RVA: 0xCD60
        public void get_Buyer(){} // RVA: 0xCD60
        public void Purchase(){}
    }

    public class Store
    {
        // ── Methods ──
        public void ClearStore(){} // RVA: 0x99E64A0
        public void OpenGroupPage(){} // RVA: 0x99E6500
        public void OpenGroupStorePage(){} // RVA: 0x99E6560
        public void OpenWorldStorePage(){} // RVA: 0x78FBA60
        public void OpenGroupListing(){} // RVA: 0x99E65C0
        public void OpenMarketplaceStore(){} // RVA: 0x99E6620
        public void OpenListing(){} // RVA: 0x99E66A0
        public void SendProductEvent(){} // RVA: 0x99E6700
        public void ListPurchases(){} // RVA: 0x99E6770
        public void ListAvailableProducts(){} // RVA: 0x99E67E0
        public void DoesPlayerOwnProduct(){} // RVA: 0x99E6840
        public void DoesAnyPlayerOwnProduct(){} // RVA: 0x99E68B0
        public void GetPlayersWhoOwnProduct(){} // RVA: 0x99E6910
        public void ListProductOwners(){} // RVA: 0x99E6970
    }

    public class UdonProduct
    {
        // ── Methods ──
        public void get_ID(){} // RVA: 0x2E07C0
        public void set_ID(){} // RVA: 0x99E50B0
        public void get_Name(){} // RVA: 0x30B0C0
        public void set_Name(){} // RVA: 0x99E5160
        public void get_Description(){} // RVA: 0x30B130
        public void set_Description(){} // RVA: 0x99E5210
        public void get_Image(){} // RVA: 0x6374D0
        public void set_Image(){} // RVA: 0x99E52C0
        public void get_Purchased(){} // RVA: 0x4A6500
        public void set_Purchased(){} // RVA: 0x4A78C0
        public void get_Buyer(){} // RVA: 0x35A740
        public void set_Buyer(){} // RVA: 0x305200
        public void Create(){} // RVA: 0x99E5320
        public void Delete(){} // RVA: 0x99E5440
        public void Purchase(){} // RVA: 0x99E5560
        public void Equals(){} // RVA: 0x99E5720
        public void ToString(){} // RVA: 0x99E57D0
        public void .ctor(){} // RVA: 0x99E58C0
    }

    public class UdonProductsCategory
    {
        public object NetworkIDCollection;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x2E07C0
        public void set_Name(){} // RVA: 0x99E61E0
        public void get_Products(){} // RVA: 0x30B0C0
        public void set_Products(){} // RVA: 0x99E6290
        public void ToString(){} // RVA: 0x99E6340
        public void .ctor(){} // RVA: 0x99E6410
    }

}