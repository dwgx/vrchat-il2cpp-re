// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 2
// Methods: 4

namespace ThirdParty.Other.Steamworks.Data
{
    public class ValidateAuthTicketResponse_t : ValueType
    {
        public ulong CallbackType; // 0x10
        public 0x6B28D6B0 AuthSessionResponse; // 0x18
        public ulong OwnerSteamID; // 0x1C
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BE8FE0
        public void .cctor(){} // RVA: 0x7FFAC4BE8FF0
    }

    public class VolumeHasChanged_t : ValueType
    {
        public float CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF0B10
        public void .cctor(){} // RVA: 0x7FFAC4BF0B20
    }

}