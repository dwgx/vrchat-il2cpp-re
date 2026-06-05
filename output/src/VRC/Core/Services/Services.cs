// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Services
// Classes: 19
// Methods: 73

namespace VRC.Core.Services
{
    public class APIEventSourceMethods
    {
        // ── Methods ──
        public void GetEndpoint(){} // RVA: 0x7FFAFC3FFD70
    }

    public class AvatarsService : GetAvatars
    {
        // ── Methods ──
        public void GetAvatars(){} // RVA: 0x7FFAFC3F0FD0
        public void GetFavoriteAvatars(){} // RVA: 0x7FFAFC3F2BD0
        public void GetLicensedAvatars(){} // RVA: 0x7FFAFC3F42A0
        public void GetStyle(){} // RVA: 0x7FFAFC3F4810
        public void GetStyles(){} // RVA: 0x7FFAFC3F4B60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class EconomyService
    {
        // ── Methods ──
        public void GetEconomyStatus(){} // RVA: 0x7FFAFC3F5D40
        public void IsUsersEconomyAccountBlocked(){} // RVA: 0x7FFAFC3F6140
        public void GetWalletBalance(){} // RVA: 0x7FFAFC3F6560
        public void GetLedgerTransactions(){} // RVA: 0x7FFAFC3F69B0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class EventsService
    {
        // ── Methods ──
        public void GetEntry(){} // RVA: 0x7FFAFC3F7B30
        public void GetAllOwnersEvents(){} // RVA: 0x7FFAFC3F7EF0
        public void GetOwnersNextEvent(){} // RVA: 0x7FFAFC3F8740
        public void GetEventsForMonth(){} // RVA: 0x7FFAFC3F8AE0
        public void FollowEvent(){} // RVA: 0x7FFAFC3F93E0
        public void SearchEvents(){} // RVA: 0x7FFAFC3F9920
        public void DiscoverEvents(){} // RVA: 0x7FFAFC3FB330 | overloaded x2
        public void GetEventsForOwnerWithinDates(){} // RVA: 0x7FFAFC3FB980
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class GroupsService
    {
        // ── Methods ──
        public void ExecuteSearch(){} // RVA: 0x7FFAFC3FDC80 | overloaded x2
        public void DiscoverGroups(){} // RVA: 0x7FFAFC3FE8F0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class HypeTrainService
    {
        // ── Methods ──
        public void GetHypeTrainInfoForInstance(){} // RVA: 0x7FFAFC3FF7C0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class IAvatarsService
    {
        // ── Methods ──
        public void GetAvatars(){} // RVA: 0x7FFAF2D33FA0
        public void GetFavoriteAvatars(){} // RVA: 0x7FFAF2D33FA0
        public void GetLicensedAvatars(){}
        public void GetStyle(){}
        public void GetStyles(){} // RVA: 0x7FFAF2ABC770
    }

    public class IEconomyService
    {
        // ── Methods ──
        public void GetEconomyStatus(){} // RVA: 0x7FFAF2ABC770
        public void IsUsersEconomyAccountBlocked(){}
        public void GetWalletBalance(){}
        public void GetLedgerTransactions(){}
    }

    public class IEventsService
    {
        // ── Methods ──
        public void GetEntry(){} // RVA: 0x7FFAF2ADF9F0
        public void GetAllOwnersEvents(){}
        public void GetOwnersNextEvent(){} // RVA: 0x7FFAF2ADF090
        public void GetEventsForMonth(){}
        public void FollowEvent(){}
        public void SearchEvents(){}
        public void DiscoverEvents(){} // overloaded x2
        public void GetEventsForOwnerWithinDates(){}
    }

    public class IGroupsService
    {
        // ── Methods ──
        public void ExecuteSearch(){} // overloaded x2
        public void DiscoverGroups(){}
    }

    public class IHypeTrainService
    {
        // ── Methods ──
        public void GetHypeTrainInfoForInstance(){}
    }

    public class IInstancesService
    {
        // ── Methods ──
        public void CloseInstance(){}
        public void EditInstanceDisplayName(){} // RVA: 0x7FFAF2ADF9F0
        public void BestPublicLocationByPopulation(){} // RVA: 0x7FFAF2ADF9F0
        public void GetLocationFromShortName(){} // RVA: 0x7FFAF2ADF090
        public void SetLinkedEvent(){}
    }

    public class IInventoryService
    {
        // ── Methods ──
        public void GetGlobalInventoryItems(){} // RVA: 0x7FFAF2ABC770
        public void UpdateGlobalInventoryItemsLastSeen(){} // RVA: 0x7FFAF2ADDC60
    }

    public class IStoresService
    {
        // ── Methods ──
        public void GetStoreShelves(){}
    }

    public class InstanceCallError
    {
        // ── Methods ──
        public void get_Code(){} // RVA: 0x7FFAF315FD40
        public void .ctor(){} // RVA: 0x7FFAFC3FFE70
    }

    public class InstancesService : CloseInstance
    {
        // ── Methods ──
        public void CloseInstance(){} // RVA: 0x7FFAFC3FFEF0
        public void EditInstanceDisplayName(){} // RVA: 0x7FFAFC400430
        public void SetLinkedEvent(){} // RVA: 0x7FFAFC400870
        public void GetLocationFromShortName(){} // RVA: 0x7FFAFC400D90
        public void BestPublicLocationByPopulation(){} // RVA: 0x7FFAFC4010E0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class InventoryService
    {
        // ── Methods ──
        public void GetGlobalInventoryItems(){} // RVA: 0x7FFAFC401BF0
        public void UpdateGlobalInventoryItemsLastSeen(){} // RVA: 0x7FFAFC402020
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class PagedEventsResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class StoresService
    {
        // ── Methods ──
        public void GetStoreShelves(){} // RVA: 0x7FFAFC402680
        public void GetEnumMemberValue(){} // RVA: 0x7FFAFC402E20
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

}