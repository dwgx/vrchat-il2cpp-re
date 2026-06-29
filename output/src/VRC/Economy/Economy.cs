// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Economy
// Classes: 5
// Methods: 58

namespace VRC.Economy
{
    public class IProduct
    {
        // ── Methods ──
        public void get_ID(){} // RVA: 0x87C0A0
        public void get_Name(){} // RVA: 0x87C0A0
        public void get_Description(){} // RVA: 0x87C0A0
        public void get_Buyer(){} // RVA: 0x87C0A0
        public void Purchase(){} // RVA: 0x88D960
    }

    public class Store : Object
    {
        public object _clearStore;
        public object _openGroupPage;
        public object _openGroupStorePage;
        public object _openWorldStorePage;
        public object _openGroupListing;
        public object _openMarketplaceStore;
        public object _openListing;
        public object _sendProductEvent;
        public object _listPurchases;
        public object _listAvailableProducts;
        public object _doesPlayerOwnProduct;
        public object _doesAnyPlayerOwnProduct;
        public object _getPlayersWhoOwnProduct;
        public object _listProductOwners;

        // ── Methods ──
        public void ClearStore(){} // RVA: 0xA690BF0
        public void OpenGroupPage(){} // RVA: 0xA690C50
        public void OpenGroupStorePage(){} // RVA: 0xA690CB0
        public void OpenWorldStorePage(){} // RVA: 0x85367D0
        public void OpenGroupListing(){} // RVA: 0xA690D10
        public void OpenMarketplaceStore(){} // RVA: 0xA690D70
        public void OpenListing(){} // RVA: 0xA690DF0
        public void SendProductEvent(){} // RVA: 0xA690E50
        public void ListPurchases(){} // RVA: 0xA690EC0
        public void ListAvailableProducts(){} // RVA: 0xA690F30
        public void DoesPlayerOwnProduct(){} // RVA: 0xA690F90
        public void DoesAnyPlayerOwnProduct(){} // RVA: 0xA691000
        public void GetPlayersWhoOwnProduct(){} // RVA: 0xA691060
        public void ListProductOwners(){} // RVA: 0xA6910C0
    }

    public class UdonProduct : ScriptableObject
    {
        public object _ID;
        public object _Name;
        public object _Description;
        public object _Image;
        public object _purchased;
        public object _buyer;

        // ── Methods ──
        public void get_ID(){} // RVA: 0xB465B0
        public void set_ID(){} // RVA: 0xA68F840
        public void get_Name(){} // RVA: 0xB700F0
        public void set_Name(){} // RVA: 0xA68F8F0
        public void get_Description(){} // RVA: 0xB70160
        public void set_Description(){} // RVA: 0xA68F9A0
        public void get_Image(){} // RVA: 0xD33E60
        public void set_Image(){} // RVA: 0xA68FA50
        public void get_Purchased(){} // RVA: 0xD16660
        public void set_Purchased(){} // RVA: 0xD14C10
        public void get_Buyer(){} // RVA: 0xBC1B30
        public void set_Buyer(){} // RVA: 0xB6A8C0
        public void Create(){} // RVA: 0xA68FAB0
        public void Delete(){} // RVA: 0xA68FBD0
        public void Purchase(){} // RVA: 0xA68FCF0
        public void Equals(){} // RVA: 0xA68FEB0
        public void ToString(){} // RVA: 0xA68FF60
        public void .ctor(){} // RVA: 0xA690050
    }

    public class UdonProduct[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class UdonProductsCategory : ScriptableObject
    {
        public object _Name;
        public object _Products;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xB465B0
        public void set_Name(){} // RVA: 0xA690960
        public void get_Products(){} // RVA: 0xB700F0
        public void set_Products(){} // RVA: 0xA690A10
        public void ToString(){} // RVA: 0xA690AC0
        public void .ctor(){} // RVA: 0xA690B80
    }

}