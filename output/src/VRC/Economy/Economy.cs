// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Economy
// Classes: 4
// Methods: 43

namespace VRC.Economy
{
    public class IProduct
    {
        public object ID;
        public object Name;
        public object Description;
        public object Buyer;

        // ── Methods ──
        public void get_ID(){} // RVA: 0x7FFD4E078E90
        public void get_Name(){} // RVA: 0x7FFD4E078E90
        public void get_Description(){} // RVA: 0x7FFD4E078E90
        public void get_Buyer(){} // RVA: 0x7FFD4E078E90
        public void Purchase(){}
    }

    public class Store : Object
    {
        // ── Methods ──
        public void ClearStore(){} // RVA: 0x7FFD57401360
        public void OpenGroupPage(){} // RVA: 0x7FFD574013C0
        public void OpenGroupStorePage(){} // RVA: 0x7FFD57401420
        public void OpenWorldStorePage(){} // RVA: 0x7FFD554A5C20
        public void OpenGroupListing(){} // RVA: 0x7FFD57401480
        public void OpenMarketplaceStore(){} // RVA: 0x7FFD574014E0
        public void OpenListing(){} // RVA: 0x7FFD57401560
        public void SendProductEvent(){} // RVA: 0x7FFD574015C0
        public void ListPurchases(){} // RVA: 0x7FFD57401630
        public void ListAvailableProducts(){} // RVA: 0x7FFD574016A0
        public void DoesPlayerOwnProduct(){} // RVA: 0x7FFD57401700
        public void DoesAnyPlayerOwnProduct(){} // RVA: 0x7FFD57401770
        public void GetPlayersWhoOwnProduct(){} // RVA: 0x7FFD574017D0
        public void ListProductOwners(){} // RVA: 0x7FFD57401830
    }

    public class UdonProduct : ScriptableObject
    {
        public object ID;
        public object Name;
        public object Description;
        public object Image;
        public object Purchased;
        public object Buyer;

        // ── Methods ──
        public void get_ID(){} // RVA: 0x7FFD4E3447C0
        public void set_ID(){} // RVA: 0x7FFD573FFF70
        public void get_Name(){} // RVA: 0x7FFD4E36F0C0
        public void set_Name(){} // RVA: 0x7FFD57400020
        public void get_Description(){} // RVA: 0x7FFD4E36F130
        public void set_Description(){} // RVA: 0x7FFD574000D0
        public void get_Image(){} // RVA: 0x7FFD4E5F95E0
        public void set_Image(){} // RVA: 0x7FFD57400180
        public void get_Purchased(){} // RVA: 0x7FFD4E5F95D0
        public void set_Purchased(){} // RVA: 0x7FFD4E5F95C0
        public void get_Buyer(){} // RVA: 0x7FFD4E3BE740
        public void set_Buyer(){} // RVA: 0x7FFD4E369200
        public void Create(){} // RVA: 0x7FFD574001E0
        public void Delete(){} // RVA: 0x7FFD57400300
        public void Purchase(){} // RVA: 0x7FFD57400420
        public void Equals(){} // RVA: 0x7FFD574005E0
        public void ToString(){} // RVA: 0x7FFD57400690
        public void .ctor(){} // RVA: 0x7FFD57400780
    }

    public class UdonProductsCategory : ScriptableObject
    {
        public object Name;
        public object Products;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD4E3447C0
        public void set_Name(){} // RVA: 0x7FFD574010A0
        public void get_Products(){} // RVA: 0x7FFD4E36F0C0
        public void set_Products(){} // RVA: 0x7FFD57401150
        public void ToString(){} // RVA: 0x7FFD57401200
        public void .ctor(){} // RVA: 0x7FFD574012D0
    }

}