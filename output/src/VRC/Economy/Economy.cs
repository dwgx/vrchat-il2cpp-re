// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Economy
// Classes: 5
// Methods: 58

namespace VRC.Economy
{
    public class IProduct
    {
        // ── Methods ──
        public void get_ID(){} // RVA: 0x7A7E00680
        public void get_Name(){} // RVA: 0x7A7E00680
        public void get_Description(){} // RVA: 0x7A7E00680
        public void get_Buyer(){} // RVA: 0x7A7E00680
        public void Purchase(){} // RVA: 0x7A7E11ED0
    }

    public class Store : Object
    {
        // ── Methods ──
        public void ClearStore(){} // RVA: 0x7B1824DC0
        public void OpenGroupPage(){} // RVA: 0x7B1824E20
        public void OpenGroupStorePage(){} // RVA: 0x7B1824E80
        public void OpenWorldStorePage(){} // RVA: 0x7AF6DB120
        public void OpenGroupListing(){} // RVA: 0x7B1824EE0
        public void OpenMarketplaceStore(){} // RVA: 0x7B1824F40
        public void OpenListing(){} // RVA: 0x7B1824FC0
        public void SendProductEvent(){} // RVA: 0x7B1825020
        public void ListPurchases(){} // RVA: 0x7B1825090
        public void ListAvailableProducts(){} // RVA: 0x7B1825100
        public void DoesPlayerOwnProduct(){} // RVA: 0x7B1825160
        public void DoesAnyPlayerOwnProduct(){} // RVA: 0x7B18251D0
        public void GetPlayersWhoOwnProduct(){} // RVA: 0x7B1825230
        public void ListProductOwners(){} // RVA: 0x7B1825290
    }

    public class UdonProduct : ScriptableObject
    {
        // ── Methods ──
        public void get_ID(){} // RVA: 0x7A80DA7B0
        public void set_ID(){} // RVA: 0x7B18239D0
        public void get_Name(){} // RVA: 0x7A81052C0
        public void set_Name(){} // RVA: 0x7B1823A80
        public void get_Description(){} // RVA: 0x7A8105330
        public void set_Description(){} // RVA: 0x7B1823B30
        public void get_Image(){} // RVA: 0x7A83F69F0
        public void set_Image(){} // RVA: 0x7B1823BE0
        public void get_Purchased(){} // RVA: 0x7A82A20A0
        public void set_Purchased(){} // RVA: 0x7A82A2C90
        public void get_Buyer(){} // RVA: 0x7A8154D80
        public void set_Buyer(){} // RVA: 0x7A80FF440
        public void Create(){} // RVA: 0x7B1823C40
        public void Delete(){} // RVA: 0x7B1823D60
        public void Purchase(){} // RVA: 0x7B1823E80
        public void Equals(){} // RVA: 0x7B1824040
        public void ToString(){} // RVA: 0x7B18240F0
        public void .ctor(){} // RVA: 0x7B18241E0
    }

    public class UdonProduct[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class UdonProductsCategory : ScriptableObject
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A80DA7B0
        public void set_Name(){} // RVA: 0x7B1824B00
        public void get_Products(){} // RVA: 0x7A81052C0
        public void set_Products(){} // RVA: 0x7B1824BB0
        public void ToString(){} // RVA: 0x7B1824C60
        public void .ctor(){} // RVA: 0x7B1824D30
    }

}