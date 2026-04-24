// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Economy
// Classes: 4
// Methods: 43

namespace VRC.Economy
{
    public class IProduct
    {
        // ── Original Methods ──
        public void get_ID(){} // RVA: 0x7ffaa86491d0
        public void get_Name(){} // RVA: 0x7ffaa86491d0
        public void get_Description(){} // RVA: 0x7ffaa86491d0
        public void get_Buyer(){} // RVA: 0x7ffaa86491d0
        public void Purchase(){}
    }

    public class Store : Object
    {
        public object _openGroupStorePage; // 0x3691AEE0
        public object _openMarketplaceStore; // 0x3691AEE0
        public object _listPurchases; // 0x3691AEE0
        public object _doesAnyPlayerOwnProduct; // 0x3691AEE0

        // ── Original Methods ──
        public void ClearStore(){} // RVA: 0x7ffab19fd030
        public void OpenGroupPage(){} // RVA: 0x7ffab19fd090
        public void OpenGroupStorePage(){} // RVA: 0x7ffab19fd0f0
        public void OpenWorldStorePage(){} // RVA: 0x7ffaafaa8640
        public void OpenGroupListing(){} // RVA: 0x7ffab19fd150
        public void OpenMarketplaceStore(){} // RVA: 0x7ffab19fd1b0
        public void OpenListing(){} // RVA: 0x7ffab19fd230
        public void SendProductEvent(){} // RVA: 0x7ffab19fd290
        public void ListPurchases(){} // RVA: 0x7ffab19fd300
        public void ListAvailableProducts(){} // RVA: 0x7ffab19fd370
        public void ListProductOwners(){} // RVA: 0x7ffab19fd500
        // ── Binary Analysis Named ──
        public void DoesPlayerOwnProduct(){} // RVA: 0x7ffab19fd3d0
        public void DoesAnyPlayerOwnProduct(){} // RVA: 0x7ffab19fd440
        public void GetPlayersWhoOwnProduct(){} // RVA: 0x7ffab19fd4a0
    }

    public class UdonProduct : ScriptableObject
    {
        public object _Description; // 0x33D20210
        public object _buyer; // 0x33D20210, was: <Buyer>k__BackingField
        public object ID; // 0x17000005
        public object Name; // 0x17000006

        // ── Original Methods ──
        public void get_ID(){} // RVA: 0x7ffaa89357c0
        public void set_ID(){} // RVA: 0x7ffab19fbc40
        public void get_Name(){} // RVA: 0x7ffaa89600c0
        public void set_Name(){} // RVA: 0x7ffab19fbcf0
        public void get_Description(){} // RVA: 0x7ffaa8960130
        public void set_Description(){} // RVA: 0x7ffab19fbda0
        public void get_Image(){} // RVA: 0x7ffaa8bfcc80
        public void set_Image(){} // RVA: 0x7ffab19fbe50
        public void get_Purchased(){} // RVA: 0x7ffaa8bfcc70
        public void set_Purchased(){} // RVA: 0x7ffaa8bfbbe0
        public void get_Buyer(){} // RVA: 0x7ffaa89af740
        public void set_Buyer(){} // RVA: 0x7ffaa895a200
        public void Create(){} // RVA: 0x7ffab19fbeb0
        public void Delete(){} // RVA: 0x7ffab19fbfd0
        public void Purchase(){} // RVA: 0x7ffab19fc0f0
        public void Equals(){} // RVA: 0x7ffab19fc2b0
        public void ToString(){} // RVA: 0x7ffab19fc360
        public void .ctor(){} // RVA: 0x7ffab19fc450
    }

    public class UdonProductsCategory : ScriptableObject
    {
        // ── Original Methods ──
        public void get_Name(){} // RVA: 0x7ffaa89357c0
        public void set_Name(){} // RVA: 0x7ffab19fcd70
        public void get_Products(){} // RVA: 0x7ffaa89600c0
        public void set_Products(){} // RVA: 0x7ffab19fce20
        public void ToString(){} // RVA: 0x7ffab19fced0
        public void .ctor(){} // RVA: 0x7ffab19fcfa0
    }

}