// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Economy
// Classes: 4
// Methods: 43

namespace VRC.Economy
{
    public class IProduct
    {
        public <>c<T> ID;
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
        public System.Action _clearStore;
        public System.Action`1<string> _openGroupPage; // 0x8
        public System.Action`1<string> _openGroupStorePage; // 0x10
        public System.Action _openWorldStorePage; // 0x18
        public System.Action`1<string> _openGroupListing; // 0x20
        public System.Action`3<string,string,string> _openMarketplaceStore; // 0x28
        public System.Action`1<string> _openListing; // 0x30
        public System.Action`2<VRC.Udon.Common.Interfaces.IUdonEventReceiver,VRC.Economy.IProduct> _sendProductEvent; // 0x38
        public System.Action`2<VRC.Udon.Common.Interfaces.IUdonEventReceiver,VRC.SDKBase.VRCPlayerApi> _listPurchases; // 0x40
        public System.Action`1<VRC.Udon.Common.Interfaces.IUdonEventReceiver> _listAvailableProducts; // 0x48
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,VRC.Economy.IProduct,bool> _doesPlayerOwnProduct; // 0x50
        public System.Func`2<VRC.Economy.IProduct,bool> _doesAnyPlayerOwnProduct; // 0x58
        public System.Func`2<VRC.Economy.IProduct,VRC.SDKBase.VRCPlayerApi[]> _getPlayersWhoOwnProduct; // 0x60
        public System.Action`2<VRC.Udon.Common.Interfaces.IUdonEventReceiver,VRC.Economy.IProduct> _listProductOwners; // 0x68

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
        public string ID; // 0x18
        public string Name; // 0x20
        public string Description; // 0x28
        public UnityEngine.Texture2D Image; // 0x30
        public bool Purchased; // 0x38
        public VRC.SDKBase.VRCPlayerApi Buyer; // 0x40

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
        public string Name; // 0x18
        public VRC.Economy.UdonProduct[] Products; // 0x20

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD4E3447C0
        public void set_Name(){} // RVA: 0x7FFD574010A0
        public void get_Products(){} // RVA: 0x7FFD4E36F0C0
        public void set_Products(){} // RVA: 0x7FFD57401150
        public void ToString(){} // RVA: 0x7FFD57401200
        public void .ctor(){} // RVA: 0x7FFD574012D0
    }

}