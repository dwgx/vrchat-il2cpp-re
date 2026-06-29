// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Services
// Classes: 19
// Methods: 69

namespace VRC.Core.Services
{
    public class APIEventSourceMethods : Object
    {
        // ── Methods ──
        public void GetEndpoint(){} // RVA: 0x7B178B7C0
    }

    public class AvatarsService : Object
    {
        // ── Methods ──
        public void GetAvatars(){} // RVA: 0x7B177CAC0
        public void GetFavoriteAvatars(){} // RVA: 0x7B177E6C0
        public void GetLicensedAvatars(){} // RVA: 0x7B177FD90
        public void GetStyle(){} // RVA: 0x7B1780310
        public void GetStyles(){} // RVA: 0x7B1780670
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class EconomyService : Object
    {
        // ── Methods ──
        public void GetEconomyStatus(){} // RVA: 0x7B1781800
        public void IsUsersEconomyAccountBlocked(){} // RVA: 0x7B1781C20
        public void GetWalletBalance(){} // RVA: 0x7B1782040
        public void GetLedgerTransactions(){} // RVA: 0x7B1782490
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class EventsService : Object
    {
        // ── Methods ──
        public void GetEntry(){} // RVA: 0x7B1783600
        public void GetAllOwnersEvents(){} // RVA: 0x7B17839C0
        public void GetOwnersNextEvent(){} // RVA: 0x7B1784210
        public void GetEventsForMonth(){} // RVA: 0x7B17845C0
        public void FollowEvent(){} // RVA: 0x7B1784EC0
        public void SearchEvents(){} // RVA: 0x7B1785410
        public void DiscoverEvents(){} // RVA: 0x7B1786E10
        public void GetEventsForOwnerWithinDates(){} // RVA: 0x7B1787460
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class GroupsService : Object
    {
        // ── Methods ──
        public void ExecuteSearch(){} // RVA: 0x7B1789700
        public void DiscoverGroups(){} // RVA: 0x7B178A350
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class HypeTrainService : Object
    {
        // ── Methods ──
        public void GetHypeTrainInfoForInstance(){} // RVA: 0x7B178B210
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class IAvatarsService
    {
        // ── Methods ──
        public void GetAvatars(){} // RVA: 0x7A8051B10
        public void GetFavoriteAvatars(){} // RVA: 0x7A8051B10
        public void GetLicensedAvatars(){} // RVA: 0x7A7E011E0
        public void GetStyle(){} // RVA: 0x7A7E00560
        public void GetStyles(){} // RVA: 0x7A7E00490
    }

    public class IEconomyService
    {
        // ── Methods ──
        public void GetEconomyStatus(){} // RVA: 0x7A7E00490
        public void IsUsersEconomyAccountBlocked(){} // RVA: 0x7A7E00560
        public void GetWalletBalance(){} // RVA: 0x7A7E00560
        public void GetLedgerTransactions(){} // RVA: 0x7A7E00630
    }

    public class IEventsService
    {
        // ── Methods ──
        public void GetEntry(){} // RVA: 0x7A7E1DB70
        public void GetAllOwnersEvents(){} // RVA: 0x7A7E1EFC0
        public void GetOwnersNextEvent(){} // RVA: 0x7A7E1DDC0
        public void GetEventsForMonth(){} // RVA: 0x7A7E1A920
        public void FollowEvent(){} // RVA: 0x7A7E21E20
        public void SearchEvents(){} // RVA: 0x7A7E23C90
        public void DiscoverEvents(){} // RVA: 0x7A7E01280
        public void GetEventsForOwnerWithinDates(){} // RVA: 0x7A7E01420
    }

    public class IGroupsService
    {
        // ── Methods ──
        public void ExecuteSearch(){} // RVA: 0x7A7E23440
        public void DiscoverGroups(){} // RVA: 0x7A7E01280
    }

    public class IHypeTrainService
    {
        // ── Methods ──
        public void GetHypeTrainInfoForInstance(){} // RVA: 0x7A7E00560
    }

    public class IInstancesService
    {
        // ── Methods ──
        public void CloseInstance(){} // RVA: 0x7A7E23210
        public void EditInstanceDisplayName(){} // RVA: 0x7A7E1DB70
        public void BestPublicLocationByPopulation(){} // RVA: 0x7A7E1DB70
        public void GetLocationFromShortName(){} // RVA: 0x7A7E1DDC0
        public void SetLinkedEvent(){} // RVA: 0x7A7E00C90
    }

    public class IInventoryService
    {
        // ── Methods ──
        public void GetGlobalInventoryItems(){} // RVA: 0x7A7E00490
        public void UpdateGlobalInventoryItemsLastSeen(){} // RVA: 0x7A7E18890
    }

    public class IStoresService
    {
        // ── Methods ──
        public void GetStoreShelves(){} // RVA: 0x7A7E00780
    }

    public class InstanceCallError : Exception
    {
        // ── Methods ──
        public void get_Code(){} // RVA: 0x7A846C760
        public void .ctor(){} // RVA: 0x7B178B8C0
    }

    public class InstancesService : Object
    {
        // ── Methods ──
        public void CloseInstance(){} // RVA: 0x7B178B940
        public void EditInstanceDisplayName(){} // RVA: 0x7B178BE90
        public void SetLinkedEvent(){} // RVA: 0x7B178C2D0
        public void GetLocationFromShortName(){} // RVA: 0x7B178C7F0
        public void BestPublicLocationByPopulation(){} // RVA: 0x7B178CB40
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class InventoryService : Object
    {
        // ── Methods ──
        public void GetGlobalInventoryItems(){} // RVA: 0x7B178D660
        public void UpdateGlobalInventoryItemsLastSeen(){} // RVA: 0x7B178DA90
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class PagedEventsResult : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class StoresService : Object
    {
        // ── Methods ──
        public void GetStoreShelves(){} // RVA: 0x7B178E0E0
        public void GetEnumMemberValue(){} // RVA: 0x7B178E870
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}