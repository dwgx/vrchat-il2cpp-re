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
        public void get_ID(){} // RVA: 0x7FFAC2C58E90
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void get_Description(){} // RVA: 0x7FFAC2C58E90
        public void get_Buyer(){} // RVA: 0x7FFAC2C58E90
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
        public void ClearStore(){} // RVA: 0x7FFACBFE1360
        public void OpenGroupPage(){} // RVA: 0x7FFACBFE13C0
        public void OpenGroupStorePage(){} // RVA: 0x7FFACBFE1420
        public void OpenWorldStorePage(){} // RVA: 0x7FFACA085C20
        public void OpenGroupListing(){} // RVA: 0x7FFACBFE1480
        public void OpenMarketplaceStore(){} // RVA: 0x7FFACBFE14E0
        public void OpenListing(){} // RVA: 0x7FFACBFE1560
        public void SendProductEvent(){} // RVA: 0x7FFACBFE15C0
        public void ListPurchases(){} // RVA: 0x7FFACBFE1630
        public void ListAvailableProducts(){} // RVA: 0x7FFACBFE16A0
        public void DoesPlayerOwnProduct(){} // RVA: 0x7FFACBFE1700
        public void DoesAnyPlayerOwnProduct(){} // RVA: 0x7FFACBFE1770
        public void GetPlayersWhoOwnProduct(){} // RVA: 0x7FFACBFE17D0
        public void ListProductOwners(){} // RVA: 0x7FFACBFE1830
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
        public void get_ID(){} // RVA: 0x7FFAC2F247C0
        public void set_ID(){} // RVA: 0x7FFACBFDFF70
        public void get_Name(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Name(){} // RVA: 0x7FFACBFE0020
        public void get_Description(){} // RVA: 0x7FFAC2F4F130
        public void set_Description(){} // RVA: 0x7FFACBFE00D0
        public void get_Image(){} // RVA: 0x7FFAC31D95E0
        public void set_Image(){} // RVA: 0x7FFACBFE0180
        public void get_Purchased(){} // RVA: 0x7FFAC31D95D0
        public void set_Purchased(){} // RVA: 0x7FFAC31D95C0
        public void get_Buyer(){} // RVA: 0x7FFAC2F9E740
        public void set_Buyer(){} // RVA: 0x7FFAC2F49200
        public void Create(){} // RVA: 0x7FFACBFE01E0
        public void Delete(){} // RVA: 0x7FFACBFE0300
        public void Purchase(){} // RVA: 0x7FFACBFE0420
        public void Equals(){} // RVA: 0x7FFACBFE05E0
        public void ToString(){} // RVA: 0x7FFACBFE0690
        public void .ctor(){} // RVA: 0x7FFACBFE0780
    }

    public class UdonProductsCategory : ScriptableObject
    {
        public string Name; // 0x18
        public VRC.Economy.UdonProduct[] Products; // 0x20

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2F247C0
        public void set_Name(){} // RVA: 0x7FFACBFE10A0
        public void get_Products(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Products(){} // RVA: 0x7FFACBFE1150
        public void ToString(){} // RVA: 0x7FFACBFE1200
        public void .ctor(){} // RVA: 0x7FFACBFE12D0
    }

}