// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 5
// Methods: 85

namespace VRC.Core
{
    public class FavoriteArea
    {
        // ── Methods ──
        public void get_Endpoint(){} // RVA: 0x990C510
        public void get_Worlds(){} // RVA: 0x30B0C0
        public void get_VRCPlusWorlds(){} // RVA: 0x30B130
        public void get_Avatars(){} // RVA: 0x6374D0
        public void get_Friends(){} // RVA: 0x4976A0
        public void .ctor(){} // RVA: 0x990C550
        public void ReloadRemoteConfigSettings(){} // RVA: 0x990DD80
        public void GetCollection(){} // RVA: 0x990E440
        public void GetDefaultList(){} // RVA: 0x990E4D0
        public void GetDefaultNameByTypeAndIndex(){} // RVA: 0x990E880
        public void GetNameByTypeAndIndex(){} // RVA: 0x990EA90
        public void GetDefaultDisplayNameByTypeAndIndex(){} // RVA: 0x990EB80
        public void GetIndexOf(){} // RVA: 0x990ED90
        public void IsFavorite(){} // RVA: 0x990EE30
        public void IsFavoriteByFavoriteId(){} // RVA: 0x990F030
        public void GetFavorite(){} // RVA: 0x990F230
        public void GetTotalFavoritesOfType(){} // RVA: 0x990F420
        public void GetTotalAccessibleFavoritesOfType(){} // RVA: 0x990F6A0
        public void GetMaximumFavorites(){} // RVA: 0x990F900
        public void FindListContainingContentId(){} // RVA: 0x9910230 | overloaded x4
        public void FindListContainingFavoriteId(){} // RVA: 0x9910550 | overloaded x4
        public void FetchListDetails(){} // RVA: 0x9910800
        public void FetchListMembers(){} // RVA: 0x9910B60
        public void FetchLists(){} // RVA: 0x9910E50
        public void .cctor(){} // RVA: 0x99115E0
        public void <FetchListDetails>g__FirstNull|42_2(){} // RVA: 0x9911C50
        public void <FetchListDetails>g__ModelFromDefaults|42_3(){} // RVA: 0x9911CA0
        public void <FetchLists>g__FirstNull|44_2(){} // RVA: 0x9911C50
        public void <FetchLists>g__ModelFromDefaults|44_3(){} // RVA: 0x9912000
    }

    public class FavoriteListModel
    {
        // ── Methods ──
        public void get_Endpoint(){} // RVA: 0x9925BE0
        public void get_ownerId(){} // RVA: 0x358D50
        public void set_ownerId(){} // RVA: 0x358D60
        public void get_ownerDisplayName(){} // RVA: 0x3A5590
        public void set_ownerDisplayName(){} // RVA: 0x3A55A0
        public void get_name(){} // RVA: 0x4C7C50
        public void set_name(){} // RVA: 0x4C34F0
        public void get_displayName(){} // RVA: 0x462D00
        public void set_displayName(){} // RVA: 0x464450
        public void get_type(){} // RVA: 0xBB90C0
        public void set_type(){} // RVA: 0xBB9E60
        public void get_visibility(){} // RVA: 0x363A7C0
        public void set_visibility(){} // RVA: 0x3C7AFE0
        public void get_tags(){} // RVA: 0x796DE0
        public void set_tags(){} // RVA: 0xB54600
        public void get_requiresSubscription(){} // RVA: 0x86DB40
        public void set_requiresSubscription(){} // RVA: 0x86DB50
        public void get_Favorites(){} // RVA: 0xA085E0
        public void MakeRequestEndpoint(){} // RVA: 0x9925C20
        public void ReadField(){} // RVA: 0x9925D20
        public void WriteField(){} // RVA: 0x99261A0
        public void RemoveFavorite(){} // RVA: 0x99263D0
        public void Delete(){} // RVA: 0x99264C0
        public void ContainsFavoriteByContentId(){} // RVA: 0x9926640
        public void ContainsFavoriteByFavoriteId(){} // RVA: 0x99266D0
        public void GetFavoriteByContentId(){} // RVA: 0x9926760
        public void GetFavoriteByFavoriteId(){} // RVA: 0x99267F0
        public void FetchMembers(){} // RVA: 0x9926880
        public void FetchMembersInternal(){} // RVA: 0x9926D60
        public void Add(){} // RVA: 0x9927440
        public void AddFavoriteIndexed(){} // RVA: 0x9927D90
        public void RemoveFavoriteIndexed(){} // RVA: 0x99263D0
        public void ReplaceFavoritesIndexed(){} // RVA: 0x9927F10
        public void TruncatedFavoriteListName(){} // RVA: 0x9928220
        public void SetNameAndPrivacy(){} // RVA: 0x9928290
        public void .ctor(){} // RVA: 0x9928560
    }

    public class FavoriteModel
    {
        // ── Methods ──
        public void get_type(){} // RVA: 0x1C91440
        public void set_type(){} // RVA: 0x1C91450
        public void get_contentId(){} // RVA: 0x3A5590
        public void set_contentId(){} // RVA: 0x3A55A0
        public void get_tags(){} // RVA: 0x4C7C50
        public void set_tags(){} // RVA: 0x4C34F0
        public void .ctor(){} // RVA: 0x9928D00
        public void ReadField(){} // RVA: 0x9928DC0
        public void WriteField(){} // RVA: 0x9928FC0
        public void Delete(){} // RVA: 0x9929110
    }

    public class FavoritePrivacyExtensions
    {
        // ── Methods ──
        public void ToFavoritePrivacy(){} // RVA: 0x99182D0
        public void ToApiString(){} // RVA: 0x9918450
    }

    public class FavoriteTypeExtensions
    {
        // ── Methods ──
        public void ToFavoriteType(){} // RVA: 0x9918570
        public void ToApiString(){} // RVA: 0x9918750
    }

}