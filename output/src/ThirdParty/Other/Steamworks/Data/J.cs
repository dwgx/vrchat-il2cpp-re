// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 2
// Methods: 4

namespace ThirdParty.Other.Steamworks.Data
{
    public class JoinClanChatRoomCompletionResult_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public 0x6B28D760 ChatRoomEnterResponse; // 0x18
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BEA960
        public void .cctor(){} // RVA: 0x7FFAC4BEA970
    }

    public class JoinPartyCallback_t : ValueType
    {
        public 0x6B28D600 CallbackType; // 0x10
        public ulong BeaconID; // 0x18
        public ulong SteamIDBeaconOwner; // 0x20
        public byte[] ConnectString; // 0x28
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BECF90
        public void .cctor(){} // RVA: 0x7FFAC4BECFA0
    }

}