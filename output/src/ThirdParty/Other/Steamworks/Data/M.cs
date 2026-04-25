// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Steamworks.Data
// Classes: 16
// Methods: 32

namespace ThirdParty.Other.Steamworks.Data
{
    public class MarketEligibilityResponse_t : ValueType
    {
        public bool CallbackType; // 0x10
        public 0x6B28D810 NotAllowedReason; // 0x14
        public uint TAllowedAtTime; // 0x18
        public int CdaySteamGuardRequiredDays; // 0x1C
        public int CdayNewDeviceCooldown; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BE9750
        public void .cctor(){} // RVA: 0x7FFAC4BE9760
    }

    public class MicroTxnAuthorizationResponse_t : ValueType
    {
        public uint CallbackType; // 0x10
        public ulong OrderID; // 0x18
        public byte Authorized; // 0x20
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BE90F0
        public void .cctor(){} // RVA: 0x7FFAC4BE9100
    }

    public class MusicPlayerRemoteToFront_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF0E40
        public void .cctor(){} // RVA: 0x7FFAC4BF0E50
    }

    public class MusicPlayerRemoteWillActivate_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF0C20
        public void .cctor(){} // RVA: 0x7FFAC4BF0C30
    }

    public class MusicPlayerRemoteWillDeactivate_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF0D30
        public void .cctor(){} // RVA: 0x7FFAC4BF0D40
    }

    public class MusicPlayerSelectsPlaylistEntry_t : ValueType
    {
        public int CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF18E0
        public void .cctor(){} // RVA: 0x7FFAC4BF18F0
    }

    public class MusicPlayerSelectsQueueEntry_t : ValueType
    {
        public int CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF17D0
        public void .cctor(){} // RVA: 0x7FFAC4BF17E0
    }

    public class MusicPlayerWantsLooped_t : ValueType
    {
        public bool CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF15B0
        public void .cctor(){} // RVA: 0x7FFAC4BF15C0
    }

    public class MusicPlayerWantsPause_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF1170
        public void .cctor(){} // RVA: 0x7FFAC4BF1180
    }

    public class MusicPlayerWantsPlayNext_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF1390
        public void .cctor(){} // RVA: 0x7FFAC4BF13A0
    }

    public class MusicPlayerWantsPlayPrevious_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF1280
        public void .cctor(){} // RVA: 0x7FFAC4BF1290
    }

    public class MusicPlayerWantsPlay_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF1060
        public void .cctor(){} // RVA: 0x7FFAC4BF1070
    }

    public class MusicPlayerWantsPlayingRepeatStatus_t : ValueType
    {
        public int CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF19F0
        public void .cctor(){} // RVA: 0x7FFAC4BF1A00
    }

    public class MusicPlayerWantsShuffled_t : ValueType
    {
        public bool CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF14A0
        public void .cctor(){} // RVA: 0x7FFAC4BF14B0
    }

    public class MusicPlayerWantsVolume_t : ValueType
    {
        public float CallbackType; // 0x10
        public int _datasize;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF16C0
        public void .cctor(){} // RVA: 0x7FFAC4BF16D0
    }

    public class MusicPlayerWillQuit_t : ValueType
    {
        public int CallbackType;

        // ── Methods ──
        public void get_CallbackType(){} // RVA: 0x7FFAC4BF0F50
        public void .cctor(){} // RVA: 0x7FFAC4BF0F60
    }

}