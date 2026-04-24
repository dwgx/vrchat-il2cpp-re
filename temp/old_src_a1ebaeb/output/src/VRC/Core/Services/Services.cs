// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Services
// Classes: 14
// Methods: 66

namespace VRC.Core.Services
{
    public class AvatarsService : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetAvatars(){} // RVA: 0x7ffab19582f0
        public void GetFavoriteAvatars(){} // RVA: 0x7ffab1959ef0
        public void GetLicensedAvatars(){} // RVA: 0x7ffab195b5c0
        public void GetStyle(){} // RVA: 0x7ffab195bb30
        public void GetStyles(){} // RVA: 0x7ffab195be80
    }

    public class EconomyService : Object
    {
        // ── Original Methods ──
        public void IsUsersEconomyAccountBlocked(){} // RVA: 0x7ffab195d460
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetEconomyStatus(){} // RVA: 0x7ffab195d060
        public void GetWalletBalance(){} // RVA: 0x7ffab195d880
        public void GetLedgerTransactions(){} // RVA: 0x7ffab195dcd0
    }

    public class EventsService : Object
    {
        // ── Original Methods ──
        public void FollowEvent(){} // RVA: 0x7ffab1960700
        public void SearchEvents(){} // RVA: 0x7ffab1960c40
        public void DiscoverEvents(){} // RVA: 0x7ffab1962650
        public void DiscoverEvents(){} // RVA: 0x7ffab1962650
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetEntry(){} // RVA: 0x7ffab195ee50
        public void GetAllOwnersEvents(){} // RVA: 0x7ffab195f210
        public void GetOwnersNextEvent(){} // RVA: 0x7ffab195fa60
        public void GetEventsForMonth(){} // RVA: 0x7ffab195fe00
        public void GetEventsForOwnerWithinDates(){} // RVA: 0x7ffab1962ca0
    }

    public class GroupsService : Object
    {
        // ── Original Methods ──
        public void ExecuteSearch(){} // RVA: 0x7ffab1964fa0
        public void ExecuteSearch(){} // RVA: 0x7ffab1964fa0
        public void DiscoverGroups(){} // RVA: 0x7ffab1965c10
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class IAvatarsService
    {
        // ── Binary Analysis Named ──
        public void GetAvatars(){} // RVA: 0x7ffaa887e5c0
        public void GetFavoriteAvatars(){} // RVA: 0x7ffaa887e5c0
        public void GetLicensedAvatars(){}
        public void GetStyle(){}
        public void GetStyles(){} // RVA: 0x7ffaa8648be0
    }

    public class IEconomyService
    {
        // ── Original Methods ──
        public void IsUsersEconomyAccountBlocked(){}
        // ── Binary Analysis Named ──
        public void GetEconomyStatus(){} // RVA: 0x7ffaa8648be0
        public void GetWalletBalance(){}
        public void GetLedgerTransactions(){}
    }

    public class IEventsService
    {
        // ── Original Methods ──
        public void FollowEvent(){}
        public void SearchEvents(){}
        public void DiscoverEvents(){}
        public void DiscoverEvents(){}
        // ── Binary Analysis Named ──
        public void GetEntry(){} // RVA: 0x7ffaa866bc00
        public void GetAllOwnersEvents(){}
        public void GetOwnersNextEvent(){} // RVA: 0x7ffaa866b2a0
        public void GetEventsForMonth(){}
        public void GetEventsForOwnerWithinDates(){}
    }

    public class IGroupsService
    {
        // ── Original Methods ──
        public void ExecuteSearch(){}
        public void ExecuteSearch(){}
        public void DiscoverGroups(){}
    }

    public class IInstancesService
    {
        // ── Original Methods ──
        public void CloseInstance(){}
        public void EditInstanceDisplayName(){} // RVA: 0x7ffaa866bc00
        public void BestPublicLocationByPopulation(){} // RVA: 0x7ffaa866bc00
        // ── Binary Analysis Named ──
        public void GetLocationFromShortName(){} // RVA: 0x7ffaa866b2a0
        public void SetLinkedEvent(){}
    }

    public class IInventoryService
    {
        // ── Original Methods ──
        public void UpdateGlobalInventoryItemsLastSeen(){} // RVA: 0x7ffaa8669e70
        // ── Binary Analysis Named ──
        public void GetGlobalInventoryItems(){} // RVA: 0x7ffaa8648be0
    }

    public class IStoresService
    {
        // ── Binary Analysis Named ──
        public void GetStoreShelves(){}
    }

    public class InstancesService : Object
    {
        // ── Original Methods ──
        public void CloseInstance(){} // RVA: 0x7ffab1966c60
        public void EditInstanceDisplayName(){} // RVA: 0x7ffab19671a0
        public void BestPublicLocationByPopulation(){} // RVA: 0x7ffab1967e50
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetLinkedEvent(){} // RVA: 0x7ffab19675e0
        public void GetLocationFromShortName(){} // RVA: 0x7ffab1967b00
    }

    public class InventoryService : Object
    {
        // ── Original Methods ──
        public void UpdateGlobalInventoryItemsLastSeen(){} // RVA: 0x7ffab1968d90
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetGlobalInventoryItems(){} // RVA: 0x7ffab1968960
    }

    public class StoresService : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetStoreShelves(){} // RVA: 0x7ffab19693f0
        public void GetEnumMemberValue(){} // RVA: 0x7ffab1969b90
    }

}