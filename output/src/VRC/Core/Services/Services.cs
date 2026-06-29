// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Services
// Classes: 19
// Methods: 69

namespace VRC.Core.Services
{
    public class APIEventSourceMethods : Object
    {
        // ── Methods ──
        public void GetEndpoint(){} // RVA: 0xA5F7930
    }

    public class AvatarsService : Object
    {
        // ── Methods ──
        public void GetAvatars(){} // RVA: 0xA5E8CC0
        public void GetFavoriteAvatars(){} // RVA: 0xA5EA930
        public void GetLicensedAvatars(){} // RVA: 0xA5EBFE0
        public void GetStyle(){} // RVA: 0xA5EC560
        public void GetStyles(){} // RVA: 0xA5EC8C0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class EconomyService : Object
    {
        // ── Methods ──
        public void GetEconomyStatus(){} // RVA: 0xA5EDA50
        public void IsUsersEconomyAccountBlocked(){} // RVA: 0xA5EDE70
        public void GetWalletBalance(){} // RVA: 0xA5EE290
        public void GetLedgerTransactions(){} // RVA: 0xA5EE6E0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class EventsService : Object
    {
        public object ListCacheTime;

        // ── Methods ──
        public void GetEntry(){} // RVA: 0xA5EF830
        public void GetAllOwnersEvents(){} // RVA: 0xA5EFBF0
        public void GetOwnersNextEvent(){} // RVA: 0xA5F0440
        public void GetEventsForMonth(){} // RVA: 0xA5F07F0
        public void FollowEvent(){} // RVA: 0xA5F10F0
        public void SearchEvents(){} // RVA: 0xA5F1640
        public void DiscoverEvents(){} // RVA: 0xA5F3010
        public void GetEventsForOwnerWithinDates(){} // RVA: 0xA5F3660
        public void .ctor(){} // RVA: 0xB43310
    }

    public class GroupsService : Object
    {
        // ── Methods ──
        public void ExecuteSearch(){} // RVA: 0xA5F58D0
        public void DiscoverGroups(){} // RVA: 0xA5F64F0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class HypeTrainService : Object
    {
        // ── Methods ──
        public void GetHypeTrainInfoForInstance(){} // RVA: 0xA5F7380
        public void .ctor(){} // RVA: 0xB43310
    }

    public class IAvatarsService
    {
        // ── Methods ──
        public void GetAvatars(){} // RVA: 0xA94080
        public void GetFavoriteAvatars(){} // RVA: 0xA94080
        public void GetLicensedAvatars(){} // RVA: 0x87CC60
        public void GetStyle(){} // RVA: 0x87BF80
        public void GetStyles(){} // RVA: 0x87BEB0
    }

    public class IEconomyService
    {
        // ── Methods ──
        public void GetEconomyStatus(){} // RVA: 0x87BEB0
        public void IsUsersEconomyAccountBlocked(){} // RVA: 0x87BF80
        public void GetWalletBalance(){} // RVA: 0x87BF80
        public void GetLedgerTransactions(){} // RVA: 0x87C050
    }

    public class IEventsService
    {
        // ── Methods ──
        public void GetEntry(){} // RVA: 0x899870
        public void GetAllOwnersEvents(){} // RVA: 0x89AC30
        public void GetOwnersNextEvent(){} // RVA: 0x8954D0
        public void GetEventsForMonth(){} // RVA: 0x896490
        public void FollowEvent(){} // RVA: 0x89DB10
        public void SearchEvents(){} // RVA: 0x89F8A0
        public void DiscoverEvents(){} // RVA: 0x87CD00
        public void GetEventsForOwnerWithinDates(){} // RVA: 0x87CEF0
    }

    public class IGroupsService
    {
        public object LIST_CACHE_TIME;
        public object SINGLE_RECORD_CACHE_TIME;

        // ── Methods ──
        public void ExecuteSearch(){} // RVA: 0x89F0B0
        public void DiscoverGroups(){} // RVA: 0x87CD00
    }

    public class IHypeTrainService
    {
        // ── Methods ──
        public void GetHypeTrainInfoForInstance(){} // RVA: 0x87BF80
    }

    public class IInstancesService
    {
        // ── Methods ──
        public void CloseInstance(){} // RVA: 0x89EE80
        public void EditInstanceDisplayName(){} // RVA: 0x899870
        public void BestPublicLocationByPopulation(){} // RVA: 0x899870
        public void GetLocationFromShortName(){} // RVA: 0x8954D0
        public void SetLinkedEvent(){} // RVA: 0x87C6B0
    }

    public class IInventoryService
    {
        // ── Methods ──
        public void GetGlobalInventoryItems(){} // RVA: 0x87BEB0
        public void UpdateGlobalInventoryItemsLastSeen(){} // RVA: 0x8943B0
    }

    public class IStoresService
    {
        // ── Methods ──
        public void GetStoreShelves(){} // RVA: 0x87C1A0
    }

    public class InstanceCallError : Exception
    {
        public object _code;

        // ── Methods ──
        public void get_Code(){} // RVA: 0xF3A950
        public void .ctor(){} // RVA: 0xA5F7A30
    }

    public class InstancesService : Object
    {
        // ── Methods ──
        public void CloseInstance(){} // RVA: 0xA5F7AB0
        public void EditInstanceDisplayName(){} // RVA: 0xA5F8000
        public void SetLinkedEvent(){} // RVA: 0xA5F8440
        public void GetLocationFromShortName(){} // RVA: 0xA5F8960
        public void BestPublicLocationByPopulation(){} // RVA: 0xA5F8CB0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class InventoryService : Object
    {
        // ── Methods ──
        public void GetGlobalInventoryItems(){} // RVA: 0xA5F97D0
        public void UpdateGlobalInventoryItemsLastSeen(){} // RVA: 0xA5F9C00
        public void .ctor(){} // RVA: 0xB43310
    }

    public class PagedEventsResult : Object
    {
        public object Events;
        public object NextCursor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class StoresService : Object
    {
        // ── Methods ──
        public void GetStoreShelves(){} // RVA: 0xA5FA240
        public void GetEnumMemberValue(){} // RVA: 0xA5FAB20
        public void .ctor(){} // RVA: 0xB43310
    }

}