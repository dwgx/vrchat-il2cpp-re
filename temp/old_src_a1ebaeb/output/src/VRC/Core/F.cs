// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 3
// Methods: 81

namespace VRC.Core
{
    public class FavoriteArea : AreaBase
    {
        public object MIN_FAVORITES_LISTS; // 0x3515F060
        public object DefaultListSorting; // 0x3515F060
        public object _avatars; // 0x3515F060

        // ── Original Methods ──
        public void get_Endpoint(){} // RVA: 0x7ffab1924480
        public void get_Worlds(){} // RVA: 0x7ffaa89600c0
        public void get_VRCPlusWorlds(){} // RVA: 0x7ffaa8960130
        public void get_Avatars(){} // RVA: 0x7ffaa8bfcc80
        public void get_Friends(){} // RVA: 0x7ffaa8bf45b0
        public void .ctor(){} // RVA: 0x7ffab19244c0
        public void ReloadRemoteConfigSettings(){} // RVA: 0x7ffab1925cf0
        public void IsFavorite(){} // RVA: 0x7ffab1926da0
        public void IsFavoriteByFavoriteId(){} // RVA: 0x7ffab1926fa0
        public void FindListContainingContentId(){} // RVA: 0x7ffab19281a0
        public void FindListContainingContentId(){} // RVA: 0x7ffab19281a0
        public void FindListContainingFavoriteId(){} // RVA: 0x7ffab19284c0
        public void FindListContainingFavoriteId(){} // RVA: 0x7ffab19284c0
        public void FindListContainingContentId(){} // RVA: 0x7ffab19281a0
        public void FindListContainingContentId(){} // RVA: 0x7ffab19281a0
        public void FindListContainingFavoriteId(){} // RVA: 0x7ffab19284c0
        public void FindListContainingFavoriteId(){} // RVA: 0x7ffab19284c0
        public void FetchListDetails(){} // RVA: 0x7ffab1928770
        public void FetchListMembers(){} // RVA: 0x7ffab1928ad0
        public void FetchLists(){} // RVA: 0x7ffab1928dc0
        public void .cctor(){} // RVA: 0x7ffab1929550
        public void <FetchListDetails>g__FirstNull|42_2(){} // RVA: 0x7ffab1929bc0
        public void <FetchListDetails>g__ModelFromDefaults|42_3(){} // RVA: 0x7ffab1929c10
        public void <FetchLists>g__FirstNull|44_2(){} // RVA: 0x7ffab1929bc0
        public void <FetchLists>g__ModelFromDefaults|44_3(){} // RVA: 0x7ffab1929f70
        // ── Binary Analysis Named ──
        public void GetCollection(){} // RVA: 0x7ffab19263b0
        public void GetDefaultList(){} // RVA: 0x7ffab1926440
        public void GetDefaultNameByTypeAndIndex(){} // RVA: 0x7ffab19267f0
        public void GetNameByTypeAndIndex(){} // RVA: 0x7ffab1926a00
        public void GetDefaultDisplayNameByTypeAndIndex(){} // RVA: 0x7ffab1926af0
        public void GetIndexOf(){} // RVA: 0x7ffab1926d00
        public void GetFavorite(){} // RVA: 0x7ffab19271a0
        public void GetTotalFavoritesOfType(){} // RVA: 0x7ffab1927390
        public void GetTotalAccessibleFavoritesOfType(){} // RVA: 0x7ffab1927610
        public void GetMaximumFavorites(){} // RVA: 0x7ffab1927870
    }

    public class FavoriteListModel : ApiModel
    {
        public object _ownerId; // 0x34781C10, was: <ownerId>k__BackingField
        public object _displayName; // 0x34781C10, was: <displayName>k__BackingField
        public object _tags; // 0x34781C10, was: <tags>k__BackingField
        public object _favoritesById; // 0x34781C10

        // ── Original Methods ──
        public void get_Endpoint(){} // RVA: 0x7ffab193d170
        public void get_ownerId(){} // RVA: 0x7ffaa89add50
        public void set_ownerId(){} // RVA: 0x7ffaa89add60
        public void get_ownerDisplayName(){} // RVA: 0x7ffaa89fa590
        public void set_ownerDisplayName(){} // RVA: 0x7ffaa89fa5a0
        public void get_name(){} // RVA: 0x7ffaa8af68f0
        public void set_name(){} // RVA: 0x7ffaa8af19e0
        public void get_displayName(){} // RVA: 0x7ffaa8d1a3b0
        public void set_displayName(){} // RVA: 0x7ffaa8efece0
        public void get_type(){} // RVA: 0x7ffaa9221d50
        public void set_type(){} // RVA: 0x7ffaa92217c0
        public void get_visibility(){} // RVA: 0x7ffaab965cc0
        public void set_visibility(){} // RVA: 0x7ffaabfb3540
        public void get_tags(){} // RVA: 0x7ffaa8d1b980
        public void set_tags(){} // RVA: 0x7ffaa8f7b070
        public void get_requiresSubscription(){} // RVA: 0x7ffaa8dcb5d0
        public void set_requiresSubscription(){} // RVA: 0x7ffaa8dc7aa0
        public void get_Favorites(){} // RVA: 0x7ffaa8f78170
        public void MakeRequestEndpoint(){} // RVA: 0x7ffab193d1b0
        public void ReadField(){} // RVA: 0x7ffab193d2b0
        public void WriteField(){} // RVA: 0x7ffab193d730
        public void RemoveFavorite(){} // RVA: 0x7ffab193d960
        public void Delete(){} // RVA: 0x7ffab193da50
        public void ContainsFavoriteByContentId(){} // RVA: 0x7ffab193dbd0
        public void ContainsFavoriteByFavoriteId(){} // RVA: 0x7ffab193dc60
        public void FetchMembers(){} // RVA: 0x7ffab193de10
        public void FetchMembersInternal(){} // RVA: 0x7ffab193e2f0
        public void Add(){} // RVA: 0x7ffab193e9d0
        public void AddFavoriteIndexed(){} // RVA: 0x7ffab193f320
        public void RemoveFavoriteIndexed(){} // RVA: 0x7ffab193d960
        public void ReplaceFavoritesIndexed(){} // RVA: 0x7ffab193f4a0
        public void TruncatedFavoriteListName(){} // RVA: 0x7ffab193f7b0
        public void .ctor(){} // RVA: 0x7ffab193faf0
        // ── Binary Analysis Named ──
        public void GetFavoriteByContentId(){} // RVA: 0x7ffab193dcf0
        public void GetFavoriteByFavoriteId(){} // RVA: 0x7ffab193dd80
        public void SetNameAndPrivacy(){} // RVA: 0x7ffab193f820
    }

    public class FavoriteModel : ApiModel
    {
        public object _tags; // 0x35D78460, was: <tags>k__BackingField
        public object Capacity; // 0x170008CD

        // ── Original Methods ──
        public void get_type(){} // RVA: 0x7ffaaa1c2a40
        public void set_type(){} // RVA: 0x7ffaaa1c2a50
        public void get_contentId(){} // RVA: 0x7ffaa89fa590
        public void set_contentId(){} // RVA: 0x7ffaa89fa5a0
        public void get_tags(){} // RVA: 0x7ffaa8af68f0
        public void set_tags(){} // RVA: 0x7ffaa8af19e0
        public void .ctor(){} // RVA: 0x7ffab1940290
        public void ReadField(){} // RVA: 0x7ffab1940350
        public void WriteField(){} // RVA: 0x7ffab1940550
        public void Delete(){} // RVA: 0x7ffab19406a0
    }

}