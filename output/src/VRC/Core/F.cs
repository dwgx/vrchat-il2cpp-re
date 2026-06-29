// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 8
// Methods: 124

namespace VRC.Core
{
    public class FavoriteArea : AreaBase
    {
        // ── Methods ──
        public void get_Endpoint(){} // RVA: 0x7B1747E20
        public void get_Worlds(){} // RVA: 0x7A81052C0
        public void get_VRCPlusWorlds(){} // RVA: 0x7A8105330
        public void get_Avatars(){} // RVA: 0x7A83F69F0
        public void get_Friends(){} // RVA: 0x7A8292C30
        public void .ctor(){} // RVA: 0x7B1747E60
        public void ReloadRemoteConfigSettings(){} // RVA: 0x7B1749690
        public void GetCollection(){} // RVA: 0x7B1749D50
        public void GetDefaultList(){} // RVA: 0x7B1749DE0
        public void GetDefaultNameByTypeAndIndex(){} // RVA: 0x7B174A190
        public void GetNameByTypeAndIndex(){} // RVA: 0x7B174A3A0
        public void GetDefaultDisplayNameByTypeAndIndex(){} // RVA: 0x7B174A490
        public void GetIndexOf(){} // RVA: 0x7B174A6A0
        public void IsFavorite(){} // RVA: 0x7B174A740
        public void IsFavoriteByFavoriteId(){} // RVA: 0x7B174A950
        public void GetFavorite(){} // RVA: 0x7B174AB60
        public void GetTotalFavoritesOfType(){} // RVA: 0x7B174AD60
        public void GetTotalAccessibleFavoritesOfType(){} // RVA: 0x7B174AFE0
        public void GetMaximumFavorites(){} // RVA: 0x7B174B240
        public void FindListContainingContentId(){} // RVA: 0x7B174BBC0
        public void FindListContainingFavoriteId(){} // RVA: 0x7B174BEE0
        public void FetchListDetails(){} // RVA: 0x7B174C180
        public void FetchListMembers(){} // RVA: 0x7B174C4E0
        public void FetchLists(){} // RVA: 0x7B174C7D0
        public void .cctor(){} // RVA: 0x7B174CF60
        public void <FetchListDetails>g__FirstNull|42_2(){} // RVA: 0x7B174D5D0
        public void <FetchListDetails>g__ModelFromDefaults|42_3(){} // RVA: 0x7B174D620
        public void <FetchLists>g__FirstNull|44_2(){} // RVA: 0x7B174D5D0
        public void <FetchLists>g__ModelFromDefaults|44_3(){} // RVA: 0x7B174D980
    }

    public class FavoriteListModel : ApiModel
    {
        // ── Methods ──
        public void get_Endpoint(){} // RVA: 0x7B1761610
        public void get_ownerId(){} // RVA: 0x7A8153390
        public void set_ownerId(){} // RVA: 0x7A81533A0
        public void get_ownerDisplayName(){} // RVA: 0x7A81A00E0
        public void set_ownerDisplayName(){} // RVA: 0x7A81A00F0
        public void get_name(){} // RVA: 0x7A82C2060
        public void set_name(){} // RVA: 0x7A82C0530
        public void get_displayName(){} // RVA: 0x7A825E100
        public void set_displayName(){} // RVA: 0x7A825F860
        public void get_type(){} // RVA: 0x7A897F560
        public void set_type(){} // RVA: 0x7A8980300
        public void get_visibility(){} // RVA: 0x7AB40DAB0
        public void set_visibility(){} // RVA: 0x7ABA6C530
        public void get_tags(){} // RVA: 0x7A8555100
        public void set_tags(){} // RVA: 0x7A8919DE0
        public void get_requiresSubscription(){} // RVA: 0x7A862ABC0
        public void set_requiresSubscription(){} // RVA: 0x7A862ABD0
        public void get_Favorites(){} // RVA: 0x7A87C5850
        public void MakeRequestEndpoint(){} // RVA: 0x7B1761650
        public void ReadField(){} // RVA: 0x7B1761750
        public void WriteField(){} // RVA: 0x7B1761BD0
        public void RemoveFavorite(){} // RVA: 0x7B1761E00
        public void Delete(){} // RVA: 0x7B1761EF0
        public void ContainsFavoriteByContentId(){} // RVA: 0x7B1762070
        public void ContainsFavoriteByFavoriteId(){} // RVA: 0x7B1762100
        public void GetFavoriteByContentId(){} // RVA: 0x7B1762190
        public void GetFavoriteByFavoriteId(){} // RVA: 0x7B1762220
        public void FetchMembers(){} // RVA: 0x7B17622B0
        public void FetchMembersInternal(){} // RVA: 0x7B1762790
        public void Add(){} // RVA: 0x7B1762E70
        public void AddFavoriteIndexed(){} // RVA: 0x7B17637C0
        public void RemoveFavoriteIndexed(){} // RVA: 0x7B1761E00
        public void ReplaceFavoritesIndexed(){} // RVA: 0x7B1763940
        public void TruncatedFavoriteListName(){} // RVA: 0x7B1763C40
        public void SetNameAndPrivacy(){} // RVA: 0x7B1763CB0
        public void .ctor(){} // RVA: 0x7B1763F60
    }

    public class FavoriteListModel[] : Array
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

    public class FavoriteModel : ApiModel
    {
        // ── Methods ──
        public void get_type(){} // RVA: 0x7A9A93870
        public void set_type(){} // RVA: 0x7A9A93880
        public void get_contentId(){} // RVA: 0x7A81A00E0
        public void set_contentId(){} // RVA: 0x7A81A00F0
        public void get_tags(){} // RVA: 0x7A82C2060
        public void set_tags(){} // RVA: 0x7A82C0530
        public void .ctor(){} // RVA: 0x7B1764700
        public void ReadField(){} // RVA: 0x7B17647C0
        public void WriteField(){} // RVA: 0x7B17649C0
        public void Delete(){} // RVA: 0x7B1764B10
    }

    public class FavoriteModel[] : Array
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

    public class FavoritePrivacyExtensions : Object
    {
        // ── Methods ──
        public void ToFavoritePrivacy(){} // RVA: 0x7B1753C80
        public void ToApiString(){} // RVA: 0x7B1753E00
    }

    public class FavoriteTypeExtensions : Object
    {
        // ── Methods ──
        public void ToFavoriteType(){} // RVA: 0x7B1753F20
        public void ToApiString(){} // RVA: 0x7B1754100
    }

    public class FavoriteType[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D3F10
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6990
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA281BF0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

}