// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 9
// Methods: 18

namespace ThirdParty.Other.Steamworks.Data
{
    public class Achievement : ValueType
    {
        public object Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x47F10
        public void ToString(){} // RVA: 0x77900
    }

    public class ActiveBeaconsUpdated_t : ValueType
    {
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x147380
        public void .cctor(){} // RVA: 0x29542C0
    }

    public class AddAppDependencyResult_t : ValueType
    {
        public object Result;
        public object PublishedFileId;
        public object AppID;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14C8F0
        public void .cctor(){} // RVA: 0x2958D80
    }

    public class AddUGCDependencyResult_t : ValueType
    {
        public object Result;
        public object PublishedFileId;
        public object ChildPublishedFileId;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14C8D0
        public void .cctor(){} // RVA: 0x2958BC0
    }

    public class AppProofOfPurchaseKeyResponse_t : ValueType
    {
        public object Result;
        public object AppID;
        public object CchKeyLength;
        public object Key;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14C070
        public void .cctor(){} // RVA: 0x29568C0
    }

    public class AppResumingFromSuspend_t : ValueType
    {
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x147030
        public void .cctor(){} // RVA: 0x2952C10
    }

    public class AssociateWithClanResult_t : ValueType
    {
        public object Result;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x14E830
        public void .cctor(){} // RVA: 0x295BDA0
    }

    public class AvailableBeaconLocationsUpdated_t : ValueType
    {
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x147370
        public void .cctor(){} // RVA: 0x29541E0
    }

    public class AvatarImageLoaded_t : ValueType
    {
        public object SteamID;
        public object Image;
        public object Wide;
        public object Tall;
        public object _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x146410
        public void .cctor(){} // RVA: 0x29516B0
    }

}