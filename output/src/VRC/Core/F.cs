// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 5
// Methods: 85

namespace VRC.Core
{
    public class FavoriteArea : AreaBase
    {
        public System.Collections.Generic.Dictionary`2<0x6B0B4F48,int> Endpoint;
        public System.Collections.Generic.Dictionary`2<0x6B0B4F48,int> Worlds; // 0x8
        public System.Collections.Generic.Dictionary`2<0x6B0B4F48,int> VRCPlusWorlds; // 0x10
        public System.Collections.Generic.Dictionary`2<0x6B0B4F48,string> Avatars; // 0x18
        public System.Collections.Generic.IReadOnlyList`1<System.Collections.Generic.IReadOnlyDictionary`2<string,string>> Friends; // 0x10
        public System.Collections.Generic.Dictionary`2<string,int> DefaultListSorting; // 0x18
        public System.Collections.Generic.List`1<VRC.Core.FavoriteListModel> _worlds; // 0x20
        public System.Collections.Generic.List`1<VRC.Core.FavoriteListModel> _vrcPlusWorlds; // 0x28
        public System.Collections.Generic.List`1<VRC.Core.FavoriteListModel> _avatars; // 0x30
        public System.Collections.Generic.List`1<VRC.Core.FavoriteListModel> _friends; // 0x38

        // ── Methods ──
        public void get_Endpoint(){} // RVA: 0x7FFACBF087B0
        public void get_Worlds(){} // RVA: 0x7FFAC2F4F0C0
        public void get_VRCPlusWorlds(){} // RVA: 0x7FFAC2F4F130
        public void get_Avatars(){} // RVA: 0x7FFAC31D95E0
        public void get_Friends(){} // RVA: 0x7FFAC31D0140
        public void .ctor(){} // RVA: 0x7FFACBF087F0
        public void ReloadRemoteConfigSettings(){} // RVA: 0x7FFACBF0A020
        public void GetCollection(){} // RVA: 0x7FFACBF0A6E0
        public void GetDefaultList(){} // RVA: 0x7FFACBF0A770
        public void GetDefaultNameByTypeAndIndex(){} // RVA: 0x7FFACBF0AB20
        public void GetNameByTypeAndIndex(){} // RVA: 0x7FFACBF0AD30
        public void GetDefaultDisplayNameByTypeAndIndex(){} // RVA: 0x7FFACBF0AE20
        public void GetIndexOf(){} // RVA: 0x7FFACBF0B030
        public void IsFavorite(){} // RVA: 0x7FFACBF0B0D0
        public void IsFavoriteByFavoriteId(){} // RVA: 0x7FFACBF0B2D0
        public void GetFavorite(){} // RVA: 0x7FFACBF0B4D0
        public void GetTotalFavoritesOfType(){} // RVA: 0x7FFACBF0B6C0
        public void GetTotalAccessibleFavoritesOfType(){} // RVA: 0x7FFACBF0B940
        public void GetMaximumFavorites(){} // RVA: 0x7FFACBF0BBA0
        public void FindListContainingContentId(){} // RVA: 0x7FFACBF0C4D0 | overloaded x4
        public void FindListContainingFavoriteId(){} // RVA: 0x7FFACBF0C7F0 | overloaded x4
        public void FetchListDetails(){} // RVA: 0x7FFACBF0CAA0
        public void FetchListMembers(){} // RVA: 0x7FFACBF0CE00
        public void FetchLists(){} // RVA: 0x7FFACBF0D0F0
        public void .cctor(){} // RVA: 0x7FFACBF0D880
        public void <FetchListDetails>g__FirstNull|42_2(){} // RVA: 0x7FFACBF0DEF0
        public void <FetchListDetails>g__ModelFromDefaults|42_3(){} // RVA: 0x7FFACBF0DF40
        public void <FetchLists>g__FirstNull|44_2(){} // RVA: 0x7FFACBF0DEF0
        public void <FetchLists>g__ModelFromDefaults|44_3(){} // RVA: 0x7FFACBF0E2A0
    }

    public class FavoriteListModel : ApiModel
    {
        public int Endpoint;
        public int ownerId;
        public string ownerDisplayName; // 0x68
        public string name; // 0x70
        public string displayName; // 0x78
        public string type; // 0x80
        public 0x6B0B4F48 visibility; // 0x88
        public 0x6B0B4E98 tags; // 0x8C
        public System.Collections.Generic.List`1<string> requiresSubscription; // 0x90
        public bool Favorites; // 0x98
        public System.Collections.Generic.List`1<VRC.Core.FavoriteModel> _favorites; // 0xA0
        public System.Collections.Generic.Dictionary`2<string,VRC.Core.FavoriteModel> _favoritesById; // 0xA8
        public System.Collections.Generic.Dictionary`2<string,VRC.Core.FavoriteModel> _favoritesByContentId; // 0xB0

        // ── Methods ──
        public void get_Endpoint(){} // RVA: 0x7FFACBF214A0
        public void get_ownerId(){} // RVA: 0x7FFAC2F9CD50
        public void set_ownerId(){} // RVA: 0x7FFAC2F9CD60
        public void get_ownerDisplayName(){} // RVA: 0x7FFAC2FE9590
        public void set_ownerDisplayName(){} // RVA: 0x7FFAC2FE95A0
        public void get_name(){} // RVA: 0x7FFAC30E5600
        public void set_name(){} // RVA: 0x7FFAC30E06F0
        public void get_displayName(){} // RVA: 0x7FFAC32EF410
        public void set_displayName(){} // RVA: 0x7FFAC34D4AA0
        public void get_type(){} // RVA: 0x7FFAC37EE8C0
        public void set_type(){} // RVA: 0x7FFAC37F9DE0
        public void get_visibility(){} // RVA: 0x7FFAC5F56E80
        public void set_visibility(){} // RVA: 0x7FFAC65A0990
        public void get_tags(){} // RVA: 0x7FFAC32EF640
        public void set_tags(){} // RVA: 0x7FFAC354E360
        public void get_requiresSubscription(){} // RVA: 0x7FFAC339A7F0
        public void set_requiresSubscription(){} // RVA: 0x7FFAC339FA20
        public void get_Favorites(){} // RVA: 0x7FFAC3543900
        public void MakeRequestEndpoint(){} // RVA: 0x7FFACBF214E0
        public void ReadField(){} // RVA: 0x7FFACBF215E0
        public void WriteField(){} // RVA: 0x7FFACBF21A60
        public void RemoveFavorite(){} // RVA: 0x7FFACBF21C90
        public void Delete(){} // RVA: 0x7FFACBF21D80
        public void ContainsFavoriteByContentId(){} // RVA: 0x7FFACBF21F00
        public void ContainsFavoriteByFavoriteId(){} // RVA: 0x7FFACBF21F90
        public void GetFavoriteByContentId(){} // RVA: 0x7FFACBF22020
        public void GetFavoriteByFavoriteId(){} // RVA: 0x7FFACBF220B0
        public void FetchMembers(){} // RVA: 0x7FFACBF22140
        public void FetchMembersInternal(){} // RVA: 0x7FFACBF22620
        public void Add(){} // RVA: 0x7FFACBF22D00
        public void AddFavoriteIndexed(){} // RVA: 0x7FFACBF23650
        public void RemoveFavoriteIndexed(){} // RVA: 0x7FFACBF21C90
        public void ReplaceFavoritesIndexed(){} // RVA: 0x7FFACBF237D0
        public void TruncatedFavoriteListName(){} // RVA: 0x7FFACBF23AE0
        public void SetNameAndPrivacy(){} // RVA: 0x7FFACBF23B50
        public void .ctor(){} // RVA: 0x7FFACBF23E20
    }

    public class FavoriteModel : ApiModel
    {
        public 0x6B0B4F48 type; // 0x68
        public string contentId; // 0x70
        public System.Collections.Generic.List`1<string> tags; // 0x78

        // ── Methods ──
        public void get_type(){} // RVA: 0x7FFAC47BAB50
        public void set_type(){} // RVA: 0x7FFAC47BAB60
        public void get_contentId(){} // RVA: 0x7FFAC2FE9590
        public void set_contentId(){} // RVA: 0x7FFAC2FE95A0
        public void get_tags(){} // RVA: 0x7FFAC30E5600
        public void set_tags(){} // RVA: 0x7FFAC30E06F0
        public void .ctor(){} // RVA: 0x7FFACBF245C0
        public void ReadField(){} // RVA: 0x7FFACBF24680
        public void WriteField(){} // RVA: 0x7FFACBF24880
        public void Delete(){} // RVA: 0x7FFACBF249D0
    }

    public class FavoritePrivacyExtensions : Object
    {
        // ── Methods ──
        public void ToFavoritePrivacy(){} // RVA: 0x7FFACBF14690
        public void ToApiString(){} // RVA: 0x7FFACBF14810
    }

    public class FavoriteTypeExtensions : Object
    {
        // ── Methods ──
        public void ToFavoriteType(){} // RVA: 0x7FFACBF14930
        public void ToApiString(){} // RVA: 0x7FFACBF14B10
    }

}