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
        public void get_ID(){} // RVA: 0x7FFAF2ABCD60
        public void get_Name(){} // RVA: 0x7FFAF2ABCD60
        public void get_Description(){} // RVA: 0x7FFAF2ABCD60
        public void get_Buyer(){} // RVA: 0x7FFAF2ABCD60
        public void Purchase(){}
    }

    public class Store
    {
        // ── Methods ──
        public void ClearStore(){} // RVA: 0x7FFAFC4964A0
        public void OpenGroupPage(){} // RVA: 0x7FFAFC496500
        public void OpenGroupStorePage(){} // RVA: 0x7FFAFC496560
        public void OpenWorldStorePage(){} // RVA: 0x7FFAFA3ABA60
        public void OpenGroupListing(){} // RVA: 0x7FFAFC4965C0
        public void OpenMarketplaceStore(){} // RVA: 0x7FFAFC496620
        public void OpenListing(){} // RVA: 0x7FFAFC4966A0
        public void SendProductEvent(){} // RVA: 0x7FFAFC496700
        public void ListPurchases(){} // RVA: 0x7FFAFC496770
        public void ListAvailableProducts(){} // RVA: 0x7FFAFC4967E0
        public void DoesPlayerOwnProduct(){} // RVA: 0x7FFAFC496840
        public void DoesAnyPlayerOwnProduct(){} // RVA: 0x7FFAFC4968B0
        public void GetPlayersWhoOwnProduct(){} // RVA: 0x7FFAFC496910
        public void ListProductOwners(){} // RVA: 0x7FFAFC496970
    }

    public class UdonProduct
    {
        // ── Methods ──
        public void get_ID(){} // RVA: 0x7FFAF2D907C0
        public void set_ID(){} // RVA: 0x7FFAFC4950B0
        public void get_Name(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Name(){} // RVA: 0x7FFAFC495160
        public void get_Description(){} // RVA: 0x7FFAF2DBB130
        public void set_Description(){} // RVA: 0x7FFAFC495210
        public void get_Image(){} // RVA: 0x7FFAF30E74D0
        public void set_Image(){} // RVA: 0x7FFAFC4952C0
        public void get_Purchased(){} // RVA: 0x7FFAF2F56500
        public void set_Purchased(){} // RVA: 0x7FFAF2F578C0
        public void get_Buyer(){} // RVA: 0x7FFAF2E0A740
        public void set_Buyer(){} // RVA: 0x7FFAF2DB5200
        public void Create(){} // RVA: 0x7FFAFC495320
        public void Delete(){} // RVA: 0x7FFAFC495440
        public void Purchase(){} // RVA: 0x7FFAFC495560
        public void Equals(){} // RVA: 0x7FFAFC495720
        public void ToString(){} // RVA: 0x7FFAFC4957D0
        public void .ctor(){} // RVA: 0x7FFAFC4958C0
    }

    public class UdonProductsCategory
    {
        public object NetworkIDCollection;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2D907C0
        public void set_Name(){} // RVA: 0x7FFAFC4961E0
        public void get_Products(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Products(){} // RVA: 0x7FFAFC496290
        public void ToString(){} // RVA: 0x7FFAFC496340
        public void .ctor(){} // RVA: 0x7FFAFC496410
    }

}