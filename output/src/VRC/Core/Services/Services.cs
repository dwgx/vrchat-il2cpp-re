// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Services
// Classes: 17
// Methods: 70

namespace VRC.Core.Services
{
    public class APIEventSourceMethods : Object
    {
        // ── Methods ──
        public void GetEndpoint(){} // RVA: 0x7FFACBF4AE10
    }

    public class AvatarsService : Object
    {
        // ── Methods ──
        public void GetAvatars(){} // RVA: 0x7FFACBF3C620
        public void GetFavoriteAvatars(){} // RVA: 0x7FFACBF3E220
        public void GetLicensedAvatars(){} // RVA: 0x7FFACBF3F8F0
        public void GetStyle(){} // RVA: 0x7FFACBF3FE60
        public void GetStyles(){} // RVA: 0x7FFACBF401B0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class EconomyService : Object
    {
        // ── Methods ──
        public void GetEconomyStatus(){} // RVA: 0x7FFACBF41390
        public void IsUsersEconomyAccountBlocked(){} // RVA: 0x7FFACBF41790
        public void GetWalletBalance(){} // RVA: 0x7FFACBF41BB0
        public void GetLedgerTransactions(){} // RVA: 0x7FFACBF42000
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class EventsService : Object
    {
        public float ListCacheTime;

        // ── Methods ──
        public void GetEntry(){} // RVA: 0x7FFACBF43180
        public void GetAllOwnersEvents(){} // RVA: 0x7FFACBF43540
        public void GetOwnersNextEvent(){} // RVA: 0x7FFACBF43D90
        public void GetEventsForMonth(){} // RVA: 0x7FFACBF44130
        public void FollowEvent(){} // RVA: 0x7FFACBF44A30
        public void SearchEvents(){} // RVA: 0x7FFACBF44F70
        public void DiscoverEvents(){} // RVA: 0x7FFACBF46980 | overloaded x2
        public void GetEventsForOwnerWithinDates(){} // RVA: 0x7FFACBF46FD0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class GroupsService : Object
    {
        // ── Methods ──
        public void ExecuteSearch(){} // RVA: 0x7FFACBF492D0 | overloaded x2
        public void DiscoverGroups(){} // RVA: 0x7FFACBF49F40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class IAvatarsService
    {
        // ── Methods ──
        public void GetAvatars(){} // RVA: 0x7FFAC2E8DC40
        public void GetFavoriteAvatars(){} // RVA: 0x7FFAC2E8DC40
        public void GetLicensedAvatars(){}
        public void GetStyle(){}
        public void GetStyles(){} // RVA: 0x7FFAC2C588A0
    }

    public class IEconomyService
    {
        // ── Methods ──
        public void GetEconomyStatus(){} // RVA: 0x7FFAC2C588A0
        public void IsUsersEconomyAccountBlocked(){}
        public void GetWalletBalance(){}
        public void GetLedgerTransactions(){}
    }

    public class IEventsService
    {
        // ── Methods ──
        public void GetEntry(){} // RVA: 0x7FFAC2C7B8C0
        public void GetAllOwnersEvents(){}
        public void GetOwnersNextEvent(){} // RVA: 0x7FFAC2C7AF60
        public void GetEventsForMonth(){}
        public void FollowEvent(){}
        public void SearchEvents(){}
        public void DiscoverEvents(){} // overloaded x2
        public void GetEventsForOwnerWithinDates(){}
    }

    public class IGroupsService
    {
        public float LIST_CACHE_TIME;
        public float SINGLE_RECORD_CACHE_TIME;

        // ── Methods ──
        public void ExecuteSearch(){} // overloaded x2
        public void DiscoverGroups(){}
    }

    public class IInstancesService
    {
        // ── Methods ──
        public void CloseInstance(){}
        public void EditInstanceDisplayName(){} // RVA: 0x7FFAC2C7B8C0
        public void BestPublicLocationByPopulation(){} // RVA: 0x7FFAC2C7B8C0
        public void GetLocationFromShortName(){} // RVA: 0x7FFAC2C7AF60
        public void SetLinkedEvent(){}
    }

    public class IInventoryService
    {
        // ── Methods ──
        public void GetGlobalInventoryItems(){} // RVA: 0x7FFAC2C588A0
        public void UpdateGlobalInventoryItemsLastSeen(){} // RVA: 0x7FFAC2C79B30
    }

    public class IStoresService
    {
        // ── Methods ──
        public void GetStoreShelves(){}
    }

    public class InstanceCallError : Exception
    {
        public int Code; // 0x90

        // ── Methods ──
        public void get_Code(){} // RVA: 0x7FFAC3220660
        public void .ctor(){} // RVA: 0x7FFACBF4AF10
    }

    public class InstancesService : Object
    {
        // ── Methods ──
        public void CloseInstance(){} // RVA: 0x7FFACBF4AF90
        public void EditInstanceDisplayName(){} // RVA: 0x7FFACBF4B4D0
        public void SetLinkedEvent(){} // RVA: 0x7FFACBF4B910
        public void GetLocationFromShortName(){} // RVA: 0x7FFACBF4BE30
        public void BestPublicLocationByPopulation(){} // RVA: 0x7FFACBF4C180
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class InventoryService : Object
    {
        // ── Methods ──
        public void GetGlobalInventoryItems(){} // RVA: 0x7FFACBF4CC90
        public void UpdateGlobalInventoryItemsLastSeen(){} // RVA: 0x7FFACBF4D0C0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class PagedEventsResult : Object
    {
        public System.Collections.Generic.IReadOnlyList`1<VRC.Core.APICalendarEntry> Events; // 0x10
        public string NextCursor; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class StoresService : Object
    {
        // ── Methods ──
        public void GetStoreShelves(){} // RVA: 0x7FFACBF4D720
        public void GetEnumMemberValue(){} // RVA: 0x7FFACBF4DEC0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}