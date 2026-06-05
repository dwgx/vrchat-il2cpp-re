// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 5
// Methods: 85

namespace VRC.Core
{
    public class FavoriteArea
    {
        // ── Methods ──
        public void get_Endpoint(){} // RVA: 0x7FFAFC3BC510
        public void get_Worlds(){} // RVA: 0x7FFAF2DBB0C0
        public void get_VRCPlusWorlds(){} // RVA: 0x7FFAF2DBB130
        public void get_Avatars(){} // RVA: 0x7FFAF30E74D0
        public void get_Friends(){} // RVA: 0x7FFAF2F476A0
        public void .ctor(){} // RVA: 0x7FFAFC3BC550
        public void ReloadRemoteConfigSettings(){} // RVA: 0x7FFAFC3BDD80
        public void GetCollection(){} // RVA: 0x7FFAFC3BE440
        public void GetDefaultList(){} // RVA: 0x7FFAFC3BE4D0
        public void GetDefaultNameByTypeAndIndex(){} // RVA: 0x7FFAFC3BE880
        public void GetNameByTypeAndIndex(){} // RVA: 0x7FFAFC3BEA90
        public void GetDefaultDisplayNameByTypeAndIndex(){} // RVA: 0x7FFAFC3BEB80
        public void GetIndexOf(){} // RVA: 0x7FFAFC3BED90
        public void IsFavorite(){} // RVA: 0x7FFAFC3BEE30
        public void IsFavoriteByFavoriteId(){} // RVA: 0x7FFAFC3BF030
        public void GetFavorite(){} // RVA: 0x7FFAFC3BF230
        public void GetTotalFavoritesOfType(){} // RVA: 0x7FFAFC3BF420
        public void GetTotalAccessibleFavoritesOfType(){} // RVA: 0x7FFAFC3BF6A0
        public void GetMaximumFavorites(){} // RVA: 0x7FFAFC3BF900
        public void FindListContainingContentId(){} // RVA: 0x7FFAFC3C0230 | overloaded x4
        public void FindListContainingFavoriteId(){} // RVA: 0x7FFAFC3C0550 | overloaded x4
        public void FetchListDetails(){} // RVA: 0x7FFAFC3C0800
        public void FetchListMembers(){} // RVA: 0x7FFAFC3C0B60
        public void FetchLists(){} // RVA: 0x7FFAFC3C0E50
        public void .cctor(){} // RVA: 0x7FFAFC3C15E0
        public void <FetchListDetails>g__FirstNull|42_2(){} // RVA: 0x7FFAFC3C1C50
        public void <FetchListDetails>g__ModelFromDefaults|42_3(){} // RVA: 0x7FFAFC3C1CA0
        public void <FetchLists>g__FirstNull|44_2(){} // RVA: 0x7FFAFC3C1C50
        public void <FetchLists>g__ModelFromDefaults|44_3(){} // RVA: 0x7FFAFC3C2000
    }

    public class FavoriteListModel
    {
        // ── Methods ──
        public void get_Endpoint(){} // RVA: 0x7FFAFC3D5BE0
        public void get_ownerId(){} // RVA: 0x7FFAF2E08D50
        public void set_ownerId(){} // RVA: 0x7FFAF2E08D60
        public void get_ownerDisplayName(){} // RVA: 0x7FFAF2E55590
        public void set_ownerDisplayName(){} // RVA: 0x7FFAF2E555A0
        public void get_name(){} // RVA: 0x7FFAF2F77C50
        public void set_name(){} // RVA: 0x7FFAF2F734F0
        public void get_displayName(){} // RVA: 0x7FFAF2F12D00
        public void set_displayName(){} // RVA: 0x7FFAF2F14450
        public void get_type(){} // RVA: 0x7FFAF36690C0
        public void set_type(){} // RVA: 0x7FFAF3669E60
        public void get_visibility(){} // RVA: 0x7FFAF60EA7C0
        public void set_visibility(){} // RVA: 0x7FFAF672AFE0
        public void get_tags(){} // RVA: 0x7FFAF3246DE0
        public void set_tags(){} // RVA: 0x7FFAF3604600
        public void get_requiresSubscription(){} // RVA: 0x7FFAF331DB40
        public void set_requiresSubscription(){} // RVA: 0x7FFAF331DB50
        public void get_Favorites(){} // RVA: 0x7FFAF34B85E0
        public void MakeRequestEndpoint(){} // RVA: 0x7FFAFC3D5C20
        public void ReadField(){} // RVA: 0x7FFAFC3D5D20
        public void WriteField(){} // RVA: 0x7FFAFC3D61A0
        public void RemoveFavorite(){} // RVA: 0x7FFAFC3D63D0
        public void Delete(){} // RVA: 0x7FFAFC3D64C0
        public void ContainsFavoriteByContentId(){} // RVA: 0x7FFAFC3D6640
        public void ContainsFavoriteByFavoriteId(){} // RVA: 0x7FFAFC3D66D0
        public void GetFavoriteByContentId(){} // RVA: 0x7FFAFC3D6760
        public void GetFavoriteByFavoriteId(){} // RVA: 0x7FFAFC3D67F0
        public void FetchMembers(){} // RVA: 0x7FFAFC3D6880
        public void FetchMembersInternal(){} // RVA: 0x7FFAFC3D6D60
        public void Add(){} // RVA: 0x7FFAFC3D7440
        public void AddFavoriteIndexed(){} // RVA: 0x7FFAFC3D7D90
        public void RemoveFavoriteIndexed(){} // RVA: 0x7FFAFC3D63D0
        public void ReplaceFavoritesIndexed(){} // RVA: 0x7FFAFC3D7F10
        public void TruncatedFavoriteListName(){} // RVA: 0x7FFAFC3D8220
        public void SetNameAndPrivacy(){} // RVA: 0x7FFAFC3D8290
        public void .ctor(){} // RVA: 0x7FFAFC3D8560
    }

    public class FavoriteModel
    {
        // ── Methods ──
        public void get_type(){} // RVA: 0x7FFAF4741440
        public void set_type(){} // RVA: 0x7FFAF4741450
        public void get_contentId(){} // RVA: 0x7FFAF2E55590
        public void set_contentId(){} // RVA: 0x7FFAF2E555A0
        public void get_tags(){} // RVA: 0x7FFAF2F77C50
        public void set_tags(){} // RVA: 0x7FFAF2F734F0
        public void .ctor(){} // RVA: 0x7FFAFC3D8D00
        public void ReadField(){} // RVA: 0x7FFAFC3D8DC0
        public void WriteField(){} // RVA: 0x7FFAFC3D8FC0
        public void Delete(){} // RVA: 0x7FFAFC3D9110
    }

    public class FavoritePrivacyExtensions
    {
        // ── Methods ──
        public void ToFavoritePrivacy(){} // RVA: 0x7FFAFC3C82D0
        public void ToApiString(){} // RVA: 0x7FFAFC3C8450
    }

    public class FavoriteTypeExtensions
    {
        // ── Methods ──
        public void ToFavoriteType(){} // RVA: 0x7FFAFC3C8570
        public void ToApiString(){} // RVA: 0x7FFAFC3C8750
    }

}