// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 5
// Methods: 85

namespace VRC.Core
{
    public class FavoriteArea : AreaBase
    {
        public System.Collections.Generic.Dictionary`2<0x664ADE14,int> MAX_FAVORITES_PER_LIST;
        public System.Collections.Generic.Dictionary`2<0x664ADE14,int> MAX_FAVORITES_LISTS; // 0x8
        public System.Collections.Generic.Dictionary`2<0x664ADE14,int> MIN_FAVORITES_LISTS; // 0x10
        public System.Collections.Generic.Dictionary`2<0x664ADE14,string> DEFAULT_FAVORITES_LIST_NAME; // 0x18
        public System.Collections.Generic.IReadOnlyList`1<System.Collections.Generic.IReadOnlyDictionary`2<string,string>> DefaultLists; // 0x10

        // ── Methods ──
        public void get_Endpoint(){} // RVA: 0x7FFE8A368FB0
        public void get_Worlds(){} // RVA: 0x7FFE811290C0
        public void get_VRCPlusWorlds(){} // RVA: 0x7FFE81129130
        public void get_Avatars(){} // RVA: 0x7FFE8144E200
        public void get_Friends(){} // RVA: 0x7FFE8143BA80
        public void .ctor(){} // RVA: 0x7FFE8A368FF0
        public void ReloadRemoteConfigSettings(){} // RVA: 0x7FFE8A36A820
        public void GetCollection(){} // RVA: 0x7FFE8A36AEE0
        public void GetDefaultList(){} // RVA: 0x7FFE8A36AF70
        public void GetDefaultNameByTypeAndIndex(){} // RVA: 0x7FFE8A36B320
        public void GetNameByTypeAndIndex(){} // RVA: 0x7FFE8A36B530
        public void GetDefaultDisplayNameByTypeAndIndex(){} // RVA: 0x7FFE8A36B620
        public void GetIndexOf(){} // RVA: 0x7FFE8A36B830
        public void IsFavorite(){} // RVA: 0x7FFE8A36B8D0
        public void IsFavoriteByFavoriteId(){} // RVA: 0x7FFE8A36BAD0
        public void GetFavorite(){} // RVA: 0x7FFE8A36BCD0
        public void GetTotalFavoritesOfType(){} // RVA: 0x7FFE8A36BEC0
        public void GetTotalAccessibleFavoritesOfType(){} // RVA: 0x7FFE8A36C140
        public void GetMaximumFavorites(){} // RVA: 0x7FFE8A36C3A0
        public void FindListContainingContentId(){} // RVA: 0x7FFE8A36CCD0 | overloaded x4
        public void FindListContainingFavoriteId(){} // RVA: 0x7FFE8A36CFF0 | overloaded x4
        public void FetchListDetails(){} // RVA: 0x7FFE8A36D2A0
        public void FetchListMembers(){} // RVA: 0x7FFE8A36D600
        public void FetchLists(){} // RVA: 0x7FFE8A36D8F0
        public void .cctor(){} // RVA: 0x7FFE8A36E080
        public void <FetchListDetails>g__FirstNull|42_2(){} // RVA: 0x7FFE8A36E6F0
        public void <FetchListDetails>g__ModelFromDefaults|42_3(){} // RVA: 0x7FFE8A36E740
        public void <FetchLists>g__FirstNull|44_2(){} // RVA: 0x7FFE8A36E6F0
        public void <FetchLists>g__ModelFromDefaults|44_3(){} // RVA: 0x7FFE8A36EAA0
    }

    public class FavoriteListModel : ApiModel
    {
        public int MAX_GROUP_NAME_LENGTH;
        public int MAX_PAGE_SIZE;
        public string _ownerId; // 0x68
        public string _ownerDisplayName; // 0x70
        public string _name; // 0x78
        public string _displayName; // 0x80
        public 0x664ADE14 _type; // 0x88
        public 0x664ADD64 _visibility; // 0x8C
        public System.Collections.Generic.List`1<string> _tags; // 0x90
        public bool _requiresSubscription; // 0x98

        // ── Methods ──
        public void get_Endpoint(){} // RVA: 0x7FFE8A381C10
        public void get_ownerId(){} // RVA: 0x7FFE81176D50
        public void set_ownerId(){} // RVA: 0x7FFE81176D60
        public void get_ownerDisplayName(){} // RVA: 0x7FFE811C3590
        public void set_ownerDisplayName(){} // RVA: 0x7FFE811C35A0
        public void get_name(){} // RVA: 0x7FFE81463AE0
        public void set_name(){} // RVA: 0x7FFE81464570
        public void get_displayName(){} // RVA: 0x7FFE81280C30
        public void set_displayName(){} // RVA: 0x7FFE81282380
        public void get_type(){} // RVA: 0x7FFE8194AD00
        public void set_type(){} // RVA: 0x7FFE8194A400
        public void get_visibility(){} // RVA: 0x7FFE842B66B0
        public void set_visibility(){} // RVA: 0x7FFE848F07E0
        public void get_tags(){} // RVA: 0x7FFE8154EB60
        public void set_tags(){} // RVA: 0x7FFE818CE320
        public void get_requiresSubscription(){} // RVA: 0x7FFE81611920
        public void set_requiresSubscription(){} // RVA: 0x7FFE81611930
        public void get_Favorites(){} // RVA: 0x7FFE8179C860
        public void MakeRequestEndpoint(){} // RVA: 0x7FFE8A381C50
        public void ReadField(){} // RVA: 0x7FFE8A381D50
        public void WriteField(){} // RVA: 0x7FFE8A3821D0
        public void RemoveFavorite(){} // RVA: 0x7FFE8A382400
        public void Delete(){} // RVA: 0x7FFE8A3824F0
        public void ContainsFavoriteByContentId(){} // RVA: 0x7FFE8A382670
        public void ContainsFavoriteByFavoriteId(){} // RVA: 0x7FFE8A382700
        public void GetFavoriteByContentId(){} // RVA: 0x7FFE8A382790
        public void GetFavoriteByFavoriteId(){} // RVA: 0x7FFE8A382820
        public void FetchMembers(){} // RVA: 0x7FFE8A3828B0
        public void FetchMembersInternal(){} // RVA: 0x7FFE8A382D90
        public void Add(){} // RVA: 0x7FFE8A383470
        public void AddFavoriteIndexed(){} // RVA: 0x7FFE8A383DC0
        public void RemoveFavoriteIndexed(){} // RVA: 0x7FFE8A382400
        public void ReplaceFavoritesIndexed(){} // RVA: 0x7FFE8A383F40
        public void TruncatedFavoriteListName(){} // RVA: 0x7FFE8A384250
        public void SetNameAndPrivacy(){} // RVA: 0x7FFE8A3842C0
        public void .ctor(){} // RVA: 0x7FFE8A384590
    }

    public class FavoriteModel : ApiModel
    {
        public 0x664ADE14 _type; // 0x68
        public string _contentId; // 0x70
        public System.Collections.Generic.List`1<string> _tags; // 0x78

        // ── Methods ──
        public void get_type(){} // RVA: 0x7FFE82A22EF0
        public void set_type(){} // RVA: 0x7FFE82A22F00
        public void get_contentId(){} // RVA: 0x7FFE811C3590
        public void set_contentId(){} // RVA: 0x7FFE811C35A0
        public void get_tags(){} // RVA: 0x7FFE81463AE0
        public void set_tags(){} // RVA: 0x7FFE81464570
        public void .ctor(){} // RVA: 0x7FFE8A384D30
        public void ReadField(){} // RVA: 0x7FFE8A384DF0
        public void WriteField(){} // RVA: 0x7FFE8A384FF0
        public void Delete(){} // RVA: 0x7FFE8A385140
    }

    public class FavoritePrivacyExtensions : Object
    {
        // ── Methods ──
        public void ToFavoritePrivacy(){} // RVA: 0x7FFE8A374D70
        public void ToApiString(){} // RVA: 0x7FFE8A374EF0
    }

    public class FavoriteTypeExtensions : Object
    {
        // ── Methods ──
        public void ToFavoriteType(){} // RVA: 0x7FFE8A375010
        public void ToApiString(){} // RVA: 0x7FFE8A3751F0
    }

}