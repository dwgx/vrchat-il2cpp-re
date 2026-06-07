// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Services
// Classes: 19
// Methods: 73

namespace VRC.Core.Services
{
    public class APIEventSourceMethods
    {
        // ── Methods ──
        public void GetEndpoint(){} // RVA: 0x994FD70
    }

    public class AvatarsService : GetAvatars
    {
        // ── Methods ──
        public void GetAvatars(){} // RVA: 0x9940FD0
        public void GetFavoriteAvatars(){} // RVA: 0x9942BD0
        public void GetLicensedAvatars(){} // RVA: 0x99442A0
        public void GetStyle(){} // RVA: 0x9944810
        public void GetStyles(){} // RVA: 0x9944B60
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class EconomyService
    {
        // ── Methods ──
        public void GetEconomyStatus(){} // RVA: 0x9945D40
        public void IsUsersEconomyAccountBlocked(){} // RVA: 0x9946140
        public void GetWalletBalance(){} // RVA: 0x9946560
        public void GetLedgerTransactions(){} // RVA: 0x99469B0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class EventsService
    {
        // ── Methods ──
        public void GetEntry(){} // RVA: 0x9947B30
        public void GetAllOwnersEvents(){} // RVA: 0x9947EF0
        public void GetOwnersNextEvent(){} // RVA: 0x9948740
        public void GetEventsForMonth(){} // RVA: 0x9948AE0
        public void FollowEvent(){} // RVA: 0x99493E0
        public void SearchEvents(){} // RVA: 0x9949920
        public void DiscoverEvents(){} // RVA: 0x994B330 | overloaded x2
        public void GetEventsForOwnerWithinDates(){} // RVA: 0x994B980
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class GroupsService
    {
        // ── Methods ──
        public void ExecuteSearch(){} // RVA: 0x994DC80 | overloaded x2
        public void DiscoverGroups(){} // RVA: 0x994E8F0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class HypeTrainService
    {
        // ── Methods ──
        public void GetHypeTrainInfoForInstance(){} // RVA: 0x994F7C0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IAvatarsService
    {
        // ── Methods ──
        public void GetAvatars(){} // RVA: 0x283FA0
        public void GetFavoriteAvatars(){} // RVA: 0x283FA0
        public void GetLicensedAvatars(){}
        public void GetStyle(){}
        public void GetStyles(){} // RVA: 0xC770
    }

    public class IEconomyService
    {
        // ── Methods ──
        public void GetEconomyStatus(){} // RVA: 0xC770
        public void IsUsersEconomyAccountBlocked(){}
        public void GetWalletBalance(){}
        public void GetLedgerTransactions(){}
    }

    public class IEventsService
    {
        // ── Methods ──
        public void GetEntry(){} // RVA: 0x2F9F0
        public void GetAllOwnersEvents(){}
        public void GetOwnersNextEvent(){} // RVA: 0x2F090
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
        public void EditInstanceDisplayName(){} // RVA: 0x2F9F0
        public void BestPublicLocationByPopulation(){} // RVA: 0x2F9F0
        public void GetLocationFromShortName(){} // RVA: 0x2F090
        public void SetLinkedEvent(){}
    }

    public class IInventoryService
    {
        // ── Methods ──
        public void GetGlobalInventoryItems(){} // RVA: 0xC770
        public void UpdateGlobalInventoryItemsLastSeen(){} // RVA: 0x2DC60
    }

    public class IStoresService
    {
        // ── Methods ──
        public void GetStoreShelves(){}
    }

    public class InstanceCallError
    {
        // ── Methods ──
        public void get_Code(){} // RVA: 0x6AFD40
        public void .ctor(){} // RVA: 0x994FE70
    }

    public class InstancesService : CloseInstance
    {
        // ── Methods ──
        public void CloseInstance(){} // RVA: 0x994FEF0
        public void EditInstanceDisplayName(){} // RVA: 0x9950430
        public void SetLinkedEvent(){} // RVA: 0x9950870
        public void GetLocationFromShortName(){} // RVA: 0x9950D90
        public void BestPublicLocationByPopulation(){} // RVA: 0x99510E0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class InventoryService
    {
        // ── Methods ──
        public void GetGlobalInventoryItems(){} // RVA: 0x9951BF0
        public void UpdateGlobalInventoryItemsLastSeen(){} // RVA: 0x9952020
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class PagedEventsResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class StoresService
    {
        // ── Methods ──
        public void GetStoreShelves(){} // RVA: 0x9952680
        public void GetEnumMemberValue(){} // RVA: 0x9952E20
        public void .ctor(){} // RVA: 0x2DD310
    }

}