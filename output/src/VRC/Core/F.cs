// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 8
// Methods: 124

namespace VRC.Core
{
    public class FavoriteArea : AreaBase
    {
        // ── Methods ──
        public void get_Endpoint(){} // RVA: 0xA5B42F0
        public void get_Worlds(){} // RVA: 0xB700F0
        public void get_VRCPlusWorlds(){} // RVA: 0xB70160
        public void get_Avatars(){} // RVA: 0xD33E60
        public void get_Friends(){} // RVA: 0xD05CA0
        public void .ctor(){} // RVA: 0xA5B4330
        public void ReloadRemoteConfigSettings(){} // RVA: 0xA5B5B60
        public void GetCollection(){} // RVA: 0xA5B6220
        public void GetDefaultList(){} // RVA: 0xA5B62B0
        public void GetDefaultNameByTypeAndIndex(){} // RVA: 0xA5B6660
        public void GetNameByTypeAndIndex(){} // RVA: 0xA5B6870
        public void GetDefaultDisplayNameByTypeAndIndex(){} // RVA: 0xA5B6960
        public void GetIndexOf(){} // RVA: 0xA5B6B70
        public void IsFavorite(){} // RVA: 0xA5B6C10
        public void IsFavoriteByFavoriteId(){} // RVA: 0xA5B6E20
        public void GetFavorite(){} // RVA: 0xA5B7030
        public void GetTotalFavoritesOfType(){} // RVA: 0xA5B7230
        public void GetTotalAccessibleFavoritesOfType(){} // RVA: 0xA5B74B0
        public void GetMaximumFavorites(){} // RVA: 0xA5B7710
        public void FindListContainingContentId(){} // RVA: 0xA5B8090
        public void FindListContainingFavoriteId(){} // RVA: 0xA5B83B0
        public void FetchListDetails(){} // RVA: 0xA5B8650
        public void FetchListMembers(){} // RVA: 0xA5B89B0
        public void FetchLists(){} // RVA: 0xA5B8CA0
        public void .cctor(){} // RVA: 0xA5B9430
        public void <FetchListDetails>g__FirstNull|42_2(){} // RVA: 0xA5B9AA0
        public void <FetchListDetails>g__ModelFromDefaults|42_3(){} // RVA: 0xA5B9AF0
        public void <FetchLists>g__FirstNull|44_2(){} // RVA: 0xA5B9AA0
        public void <FetchLists>g__ModelFromDefaults|44_3(){} // RVA: 0xA5B9E50
    }

    public class FavoriteListModel : ApiModel
    {
        // ── Methods ──
        public void get_Endpoint(){} // RVA: 0xA5CD8C0
        public void get_ownerId(){} // RVA: 0xBBFF90
        public void set_ownerId(){} // RVA: 0xBBFFA0
        public void get_ownerDisplayName(){} // RVA: 0xC10050
        public void set_ownerDisplayName(){} // RVA: 0xC10060
        public void get_name(){} // RVA: 0xCD3320
        public void set_name(){} // RVA: 0xCD4740
        public void get_displayName(){} // RVA: 0xCD48B0
        public void set_displayName(){} // RVA: 0xCD3600
        public void get_type(){} // RVA: 0x14780B0
        public void set_type(){} // RVA: 0x147EE80
        public void get_visibility(){} // RVA: 0x40A8A30
        public void set_visibility(){} // RVA: 0x46CB6C0
        public void get_tags(){} // RVA: 0x1069350
        public void set_tags(){} // RVA: 0xD5CC10
        public void get_requiresSubscription(){} // RVA: 0x11319D0
        public void set_requiresSubscription(){} // RVA: 0x112ECB0
        public void get_Favorites(){} // RVA: 0x106A050
        public void MakeRequestEndpoint(){} // RVA: 0xA5CD900
        public void ReadField(){} // RVA: 0xA5CDA00
        public void WriteField(){} // RVA: 0xA5CDE80
        public void RemoveFavorite(){} // RVA: 0xA5CE0B0
        public void Delete(){} // RVA: 0xA5CE1A0
        public void ContainsFavoriteByContentId(){} // RVA: 0xA5CE320
        public void ContainsFavoriteByFavoriteId(){} // RVA: 0xA5CE3B0
        public void GetFavoriteByContentId(){} // RVA: 0xA5CE440
        public void GetFavoriteByFavoriteId(){} // RVA: 0xA5CE4D0
        public void FetchMembers(){} // RVA: 0xA5CE560
        public void FetchMembersInternal(){} // RVA: 0xA5CEA40
        public void Add(){} // RVA: 0xA5CF120
        public void AddFavoriteIndexed(){} // RVA: 0xA5CFA70
        public void RemoveFavoriteIndexed(){} // RVA: 0xA5CE0B0
        public void ReplaceFavoritesIndexed(){} // RVA: 0xA5CFBF0
        public void TruncatedFavoriteListName(){} // RVA: 0xA5CFEF0
        public void SetNameAndPrivacy(){} // RVA: 0xA5CFFC0
        public void .ctor(){} // RVA: 0xA5D02B0
    }

    public class FavoriteListModel[] : Array
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

    public class FavoriteModel : ApiModel
    {
        // ── Methods ──
        public void get_type(){} // RVA: 0x2536460
        public void set_type(){} // RVA: 0x25406E0
        public void get_contentId(){} // RVA: 0xC10050
        public void set_contentId(){} // RVA: 0xC10060
        public void get_tags(){} // RVA: 0xCD3320
        public void set_tags(){} // RVA: 0xCD4740
        public void .ctor(){} // RVA: 0xA5D0A50
        public void ReadField(){} // RVA: 0xA5D0B10
        public void WriteField(){} // RVA: 0xA5D0D10
        public void Delete(){} // RVA: 0xA5D0E60
    }

    public class FavoriteModel[] : Array
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

    public class FavoritePrivacyExtensions : Object
    {
        // ── Methods ──
        public void ToFavoritePrivacy(){} // RVA: 0xA5C0000
        public void ToApiString(){} // RVA: 0xA5C0180
    }

    public class FavoriteTypeExtensions : Object
    {
        // ── Methods ──
        public void ToFavoriteType(){} // RVA: 0xA5C02A0
        public void ToApiString(){} // RVA: 0xA5C0480
    }

    public class FavoriteType[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB23C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8440
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6D5F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

}