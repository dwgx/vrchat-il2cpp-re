// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Services
// Classes: 14
// Methods: 66

namespace VRC.Core.Services
{
    public class AvatarsService : Object
    {
        // ── Methods ──
        public void GetAvatars(){} // RVA: 0x7FFD5735C620
        public void GetFavoriteAvatars(){} // RVA: 0x7FFD5735E220
        public void GetLicensedAvatars(){} // RVA: 0x7FFD5735F8F0
        public void GetStyle(){} // RVA: 0x7FFD5735FE60
        public void GetStyles(){} // RVA: 0x7FFD573601B0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class EconomyService : Object
    {
        // ── Methods ──
        public void GetEconomyStatus(){} // RVA: 0x7FFD57361390
        public void IsUsersEconomyAccountBlocked(){} // RVA: 0x7FFD57361790
        public void GetWalletBalance(){} // RVA: 0x7FFD57361BB0
        public void GetLedgerTransactions(){} // RVA: 0x7FFD57362000
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class EventsService : Object
    {
        // ── Methods ──
        public void GetEntry(){} // RVA: 0x7FFD57363180
        public void GetAllOwnersEvents(){} // RVA: 0x7FFD57363540
        public void GetOwnersNextEvent(){} // RVA: 0x7FFD57363D90
        public void GetEventsForMonth(){} // RVA: 0x7FFD57364130
        public void FollowEvent(){} // RVA: 0x7FFD57364A30
        public void SearchEvents(){} // RVA: 0x7FFD57364F70
        public void DiscoverEvents(){} // RVA: 0x7FFD57366980 | overloaded x2
        public void GetEventsForOwnerWithinDates(){} // RVA: 0x7FFD57366FD0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class GroupsService : Object
    {
        // ── Methods ──
        public void ExecuteSearch(){} // RVA: 0x7FFD573692D0 | overloaded x2
        public void DiscoverGroups(){} // RVA: 0x7FFD57369F40
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class IAvatarsService
    {
        // ── Methods ──
        public void GetAvatars(){} // RVA: 0x7FFD4E2ADC40
        public void GetFavoriteAvatars(){} // RVA: 0x7FFD4E2ADC40
        public void GetLicensedAvatars(){}
        public void GetStyle(){}
        public void GetStyles(){} // RVA: 0x7FFD4E0788A0
    }

    public class IEconomyService
    {
        // ── Methods ──
        public void GetEconomyStatus(){} // RVA: 0x7FFD4E0788A0
        public void IsUsersEconomyAccountBlocked(){}
        public void GetWalletBalance(){}
        public void GetLedgerTransactions(){}
    }

    public class IEventsService
    {
        // ── Methods ──
        public void GetEntry(){} // RVA: 0x7FFD4E09B8C0
        public void GetAllOwnersEvents(){}
        public void GetOwnersNextEvent(){} // RVA: 0x7FFD4E09AF60
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
        public void EditInstanceDisplayName(){} // RVA: 0x7FFD4E09B8C0
        public void BestPublicLocationByPopulation(){} // RVA: 0x7FFD4E09B8C0
        public void GetLocationFromShortName(){} // RVA: 0x7FFD4E09AF60
        public void SetLinkedEvent(){}
    }

    public class IInventoryService
    {
        // ── Methods ──
        public void GetGlobalInventoryItems(){} // RVA: 0x7FFD4E0788A0
        public void UpdateGlobalInventoryItemsLastSeen(){} // RVA: 0x7FFD4E099B30
    }

    public class IStoresService
    {
        // ── Methods ──
        public void GetStoreShelves(){}
    }

    public class InstancesService : Object
    {
        // ── Methods ──
        public void CloseInstance(){} // RVA: 0x7FFD5736AF90
        public void EditInstanceDisplayName(){} // RVA: 0x7FFD5736B4D0
        public void SetLinkedEvent(){} // RVA: 0x7FFD5736B910
        public void GetLocationFromShortName(){} // RVA: 0x7FFD5736BE30
        public void BestPublicLocationByPopulation(){} // RVA: 0x7FFD5736C180
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class InventoryService : Object
    {
        // ── Methods ──
        public void GetGlobalInventoryItems(){} // RVA: 0x7FFD5736CC90
        public void UpdateGlobalInventoryItemsLastSeen(){} // RVA: 0x7FFD5736D0C0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class StoresService : Object
    {
        // ── Methods ──
        public void GetStoreShelves(){} // RVA: 0x7FFD5736D720
        public void GetEnumMemberValue(){} // RVA: 0x7FFD5736DEC0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

}