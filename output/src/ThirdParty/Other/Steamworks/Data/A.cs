// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 9
// Methods: 18

namespace ThirdParty.Other.Steamworks.Data
{
    public class Achievement : ValueType
    {
        public string Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC38DFE40
        public void ToString(){} // RVA: 0x7FFAC3AD9F60
    }

    public class ActiveBeaconsUpdated_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BED4E0
        public void .cctor(){} // RVA: 0x7FFAC4BED4F0
    }

    public class AddAppDependencyResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x18
        public Steamworks.AppId AppID; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF2F30
        public void .cctor(){} // RVA: 0x7FFAC4BF2F40
    }

    public class AddUGCDependencyResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public Steamworks.Data.PublishedFileId PublishedFileId; // 0x18
        public Steamworks.Data.PublishedFileId ChildPublishedFileId; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF2D10
        public void .cctor(){} // RVA: 0x7FFAC4BF2D20
    }

    public class AppProofOfPurchaseKeyResponse_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public uint AppID; // 0x14
        public uint CchKeyLength; // 0x18
        public byte[] Key; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF0290
        public void .cctor(){} // RVA: 0x7FFAC4BF02A0
    }

    public class AppResumingFromSuspend_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEB950
        public void .cctor(){} // RVA: 0x7FFAC4BEB960
    }

    public class AssociateWithClanResult_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF69A0
        public void .cctor(){} // RVA: 0x7FFAC4BF69B0
    }

    public class AvailableBeaconLocationsUpdated_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BED3D0
        public void .cctor(){} // RVA: 0x7FFAC4BED3E0
    }

    public class AvatarImageLoaded_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public int Image; // 0x18
        public int Wide; // 0x1C
        public int Tall; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BE9FD0
        public void .cctor(){} // RVA: 0x7FFAC4BE9FE0
    }

}