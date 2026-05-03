// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Services
// Classes: 17
// Methods: 70

namespace VRC.Core.Services
{
    public class APIEventSourceMethods : Object
    {
        // ── Methods ──
        public void GetEndpoint(){} // RVA: 0x7FFE8A3AB980
    }

    public class AvatarsService : Object
    {
        // ── Methods ──
        public void GetAvatars(){} // RVA: 0x7FFE8A39D190
        public void GetFavoriteAvatars(){} // RVA: 0x7FFE8A39ED90
        public void GetLicensedAvatars(){} // RVA: 0x7FFE8A3A0460
        public void GetStyle(){} // RVA: 0x7FFE8A3A09D0
        public void GetStyles(){} // RVA: 0x7FFE8A3A0D20
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class EconomyService : Object
    {
        // ── Methods ──
        public void GetEconomyStatus(){} // RVA: 0x7FFE8A3A1F00
        public void IsUsersEconomyAccountBlocked(){} // RVA: 0x7FFE8A3A2300
        public void GetWalletBalance(){} // RVA: 0x7FFE8A3A2720
        public void GetLedgerTransactions(){} // RVA: 0x7FFE8A3A2B70
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class EventsService : Object
    {
        // ── Methods ──
        public void GetEntry(){} // RVA: 0x7FFE8A3A3CF0
        public void GetAllOwnersEvents(){} // RVA: 0x7FFE8A3A40B0
        public void GetOwnersNextEvent(){} // RVA: 0x7FFE8A3A4900
        public void GetEventsForMonth(){} // RVA: 0x7FFE8A3A4CA0
        public void FollowEvent(){} // RVA: 0x7FFE8A3A55A0
        public void SearchEvents(){} // RVA: 0x7FFE8A3A5AE0
        public void DiscoverEvents(){} // RVA: 0x7FFE8A3A74F0 | overloaded x2
        public void GetEventsForOwnerWithinDates(){} // RVA: 0x7FFE8A3A7B40
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class GroupsService : Object
    {
        // ── Methods ──
        public void ExecuteSearch(){} // RVA: 0x7FFE8A3A9E40 | overloaded x2
        public void DiscoverGroups(){} // RVA: 0x7FFE8A3AAAB0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class IAvatarsService
    {
        // ── Methods ──
        public void GetAvatars(){} // RVA: 0x7FFE810A1420
        public void GetFavoriteAvatars(){} // RVA: 0x7FFE810A1420
        public void GetLicensedAvatars(){}
        public void GetStyle(){}
        public void GetStyles(){} // RVA: 0x7FFE80E2DCF0
    }

    public class IEconomyService
    {
        // ── Methods ──
        public void GetEconomyStatus(){} // RVA: 0x7FFE80E2DCF0
        public void IsUsersEconomyAccountBlocked(){}
        public void GetWalletBalance(){}
        public void GetLedgerTransactions(){}
    }

    public class IEventsService
    {
        // ── Methods ──
        public void GetEntry(){} // RVA: 0x7FFE80E50FC0
        public void GetAllOwnersEvents(){}
        public void GetOwnersNextEvent(){} // RVA: 0x7FFE80E50660
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

    public class IInstancesService
    {
        // ── Methods ──
        public void CloseInstance(){}
        public void EditInstanceDisplayName(){} // RVA: 0x7FFE80E50FC0
        public void BestPublicLocationByPopulation(){} // RVA: 0x7FFE80E50FC0
        public void GetLocationFromShortName(){} // RVA: 0x7FFE80E50660
        public void SetLinkedEvent(){}
    }

    public class IInventoryService
    {
        // ── Methods ──
        public void GetGlobalInventoryItems(){} // RVA: 0x7FFE80E2DCF0
        public void UpdateGlobalInventoryItemsLastSeen(){} // RVA: 0x7FFE80E4F230
    }

    public class IStoresService
    {
        // ── Methods ──
        public void GetStoreShelves(){}
    }

    public class InstanceCallError : Exception
    {
        public int _code; // 0x90

        // ── Methods ──
        public void get_Code(){} // RVA: 0x7FFE814AA220
        public void .ctor(){} // RVA: 0x7FFE8A3ABA80
    }

    public class InstancesService : Object
    {
        // ── Methods ──
        public void CloseInstance(){} // RVA: 0x7FFE8A3ABB00
        public void EditInstanceDisplayName(){} // RVA: 0x7FFE8A3AC040
        public void SetLinkedEvent(){} // RVA: 0x7FFE8A3AC480
        public void GetLocationFromShortName(){} // RVA: 0x7FFE8A3AC9A0
        public void BestPublicLocationByPopulation(){} // RVA: 0x7FFE8A3ACCF0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class InventoryService : Object
    {
        // ── Methods ──
        public void GetGlobalInventoryItems(){} // RVA: 0x7FFE8A3AD800
        public void UpdateGlobalInventoryItemsLastSeen(){} // RVA: 0x7FFE8A3ADC30
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class PagedEventsResult : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class StoresService : Object
    {
        // ── Methods ──
        public void GetStoreShelves(){} // RVA: 0x7FFE8A3AE290
        public void GetEnumMemberValue(){} // RVA: 0x7FFE8A3AEA30
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}