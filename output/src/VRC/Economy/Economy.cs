// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Economy
// Classes: 4
// Methods: 43

namespace VRC.Economy
{
    public class IProduct
    {
        // ── Methods ──
        public void get_ID(){} // RVA: 0x7FFE80E2E2E0
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
        public void get_Description(){} // RVA: 0x7FFE80E2E2E0
        public void get_Buyer(){} // RVA: 0x7FFE80E2E2E0
        public void Purchase(){}
    }

    public class Store : Object
    {
        // ── Methods ──
        public void ClearStore(){} // RVA: 0x7FFE8A441ED0
        public void OpenGroupPage(){} // RVA: 0x7FFE8A441F30
        public void OpenGroupStorePage(){} // RVA: 0x7FFE8A441F90
        public void OpenWorldStorePage(){} // RVA: 0x7FFE884386D0
        public void OpenGroupListing(){} // RVA: 0x7FFE8A441FF0
        public void OpenMarketplaceStore(){} // RVA: 0x7FFE8A442050
        public void OpenListing(){} // RVA: 0x7FFE8A4420D0
        public void SendProductEvent(){} // RVA: 0x7FFE8A442130
        public void ListPurchases(){} // RVA: 0x7FFE8A4421A0
        public void ListAvailableProducts(){} // RVA: 0x7FFE8A442210
        public void DoesPlayerOwnProduct(){} // RVA: 0x7FFE8A442270
        public void DoesAnyPlayerOwnProduct(){} // RVA: 0x7FFE8A4422E0
        public void GetPlayersWhoOwnProduct(){} // RVA: 0x7FFE8A442340
        public void ListProductOwners(){} // RVA: 0x7FFE8A4423A0
    }

    public class UdonProduct : ScriptableObject
    {
        public string _ID; // 0x18
        public string _Name; // 0x20
        public string _Description; // 0x28
        public UnityEngine.Texture2D _Image; // 0x30
        public bool _purchased; // 0x38
        public VRC.SDKBase.VRCPlayerApi _buyer; // 0x40

        // ── Methods ──
        public void get_ID(){} // RVA: 0x7FFE810FE7C0
        public void set_ID(){} // RVA: 0x7FFE8A440AE0
        public void get_Name(){} // RVA: 0x7FFE811290C0
        public void set_Name(){} // RVA: 0x7FFE8A440B90
        public void get_Description(){} // RVA: 0x7FFE81129130
        public void set_Description(){} // RVA: 0x7FFE8A440C40
        public void get_Image(){} // RVA: 0x7FFE8144E200
        public void set_Image(){} // RVA: 0x7FFE8A440CF0
        public void get_Purchased(){} // RVA: 0x7FFE812CF770
        public void set_Purchased(){} // RVA: 0x7FFE812D0010
        public void get_Buyer(){} // RVA: 0x7FFE81178740
        public void set_Buyer(){} // RVA: 0x7FFE81123200
        public void Create(){} // RVA: 0x7FFE8A440D50
        public void Delete(){} // RVA: 0x7FFE8A440E70
        public void Purchase(){} // RVA: 0x7FFE8A440F90
        public void Equals(){} // RVA: 0x7FFE8A441150
        public void ToString(){} // RVA: 0x7FFE8A441200
        public void .ctor(){} // RVA: 0x7FFE8A4412F0
    }

    public class UdonProductsCategory : ScriptableObject
    {
        public string _Name; // 0x18
        public VRC.Economy.UdonProduct[] _Products; // 0x20

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE810FE7C0
        public void set_Name(){} // RVA: 0x7FFE8A441C10
        public void get_Products(){} // RVA: 0x7FFE811290C0
        public void set_Products(){} // RVA: 0x7FFE8A441CC0
        public void ToString(){} // RVA: 0x7FFE8A441D70
        public void .ctor(){} // RVA: 0x7FFE8A441E40
    }

}